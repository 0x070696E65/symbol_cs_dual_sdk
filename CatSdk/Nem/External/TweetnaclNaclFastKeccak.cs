using CatSdk.Crypto;
using Org.BouncyCastle.Crypto.Digests;

namespace CatSdk.Nem.External
{
    public class TweetnaclNaclFastKeccak
{
    private static void ScalarBase(long[][] p, byte[] s) {
        var q = new[] {NaclCatapult.Gf(), NaclCatapult.Gf(), NaclCatapult.Gf(), NaclCatapult.Gf()};
        NaclCatapult.Set25519(q[0], X);
        NaclCatapult.Set25519(q[1], Y);
        NaclCatapult.Set25519(q[2], gf1);
        NaclCatapult.M(q[3], X, Y);
        NaclCatapult.Scalarmult(p, q, s);
    }

    private static void CryptoHash(IList<byte> outArr, byte[] m, int n)
    {
        var hashBUilder = new KeccakDigest(512);
        var copied = new byte[n];
        m.ToList().CopyTo(0, copied, 0, n);

        hashBUilder.BlockUpdate(copied, 0, copied.Length);
        var hash = new byte[64];
        hashBUilder.DoFinal(hash, 0);
        for (var i = 0; i < outArr.Count; ++i)
            outArr[i] = hash[i];
    }
    private static void CryptoSignKeypair(long[] pk, byte[] sk, bool seeded)
    {
        var d = new byte[64];
        var p = new[] {NaclCatapult.Gf(), NaclCatapult.Gf(), NaclCatapult.Gf(), NaclCatapult.Gf()};
        if (!seeded) sk = Crypto.Crypto.RandomBytes(32);
        CryptoHash(d, sk, 32);
        d[0] &= 248;
        d[31] &= 127;
        d[31] |= 64;
        ScalarBase(p, d);
        NaclCatapult.Pack(pk, p);
        for (var i = 0; i < 32; i++) sk[i+32] = (byte)pk[i];
    }
    
    public static Dictionary<string, byte[]> FromSeed(byte[] seed)
    {
        if (seed.Length != crypto_sign_SEEDBYTES)
            throw new Exception("bad seed size");
        var pk = new long[crypto_sign_PUBLICKEYBYTES];
        var sk = new byte[crypto_sign_SECRETKEYBYTES];
        for (var i = 0; i < 32; i++) sk[i] = seed[i];
        CryptoSignKeypair(pk, sk, true);
        var newPk = new byte[32];
        for (var j = 0; j < pk.Length; j++)
        {
            newPk[j] = (byte) pk[j];
        }
        return new Dictionary<string, byte[]>()
        {
            {"publicKey", newPk},
            {"secretKey", sk},
        };
    }
    
    static decimal[] L = {
        0xed, 0xd3, 0xf5, 0x5c, 0x1a, 0x63, 0x12, 0x58, 0xd6, 0x9c, 0xf7, 0xa2, 0xde, 0xf9, 0xde, 0x14, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x10
    };
        
    public static void ModL(byte[] r, decimal[] x) {
        int i, j, k;
        decimal carry;
        for (i = 63; i >= 32; --i) {
            carry = 0;
            for (j = i - 32, k = i - 12; j < k; ++j) {
                x[j] += carry - 16 * x[i] * L[j - (i - 32)];
                carry = Math.Floor((x[j] + 128) / 256);
                x[j] -= carry * 256;
            }
            x[j] += carry;
            x[i] = 0;
        }

        carry = 0;
        for (j = 0; j < 32; j++) {
            x[j] += carry - ((int)x[31] >> 4) * L[j];
            carry = (int)x[j] >> 8;
            x[j] = (int)x[j] & 255;
        }
        for (j = 0; j < 32; j++) x[j] -= carry * L[j];
        for (i = 0; i < 32; i++) {
            x[i+1] += (int)x[i] >> 8;
            r[i] = (byte)((int)x[i] & 255);
        }
    }
    
    public static void Reduce(byte[] r)
    {
        var x = new decimal[64];
        for (var i = 0; i < 64; i++) x[i] = r[i];
        for (var i = 0; i < 64; i++) r[i] = 0;
        ModL(r, x);
    }

    public static int CryptoSign(byte[] sm, byte[] m, int n, byte[] sk)
    {
        byte[] d = new byte[64], h = new byte[64], r = new byte[64];
        var i = 0; var j = 0;
        var x = new decimal[64];
        var p = new[] {NaclCatapult.Gf(), NaclCatapult.Gf(), NaclCatapult.Gf(), NaclCatapult.Gf()};
        CryptoHash(d, sk, 32);
        d[0] &= 248;
        d[31] &= 127;
        d[31] |= 64;

        var smlen = n + 64;
        for (i = 0; i < n; i++) sm[64 + i] = m[i];
        for (i = 0; i < 32; i++) sm[32 + i] = d[32 + i];

        CryptoHash(r, sm.ToList().GetRange(32, sm.Length - 32).ToArray(), n+32);
        Reduce(r);
        ScalarBase(p, r);
        
        var longArr = new long[sm.Length];
        for (var k = 0; k < longArr.Length; k++)
            longArr[k] = sm[k];
        NaclCatapult.Pack(longArr, p);
        for (var k = 0; k < longArr.Length; k++)
            sm[k] = (byte)longArr[k];
        for (i = 32; i < 64; i++) sm[i] = sk[i];
        
        CryptoHash(h, sm, n + 64);
        Reduce(h);

        for (i = 0; i < 64; i++) x[i] = 0;
        for (i = 0; i < 32; i++) x[i] = r[i];
        for (i = 0; i < 32; i++) {
            for (j = 0; j < 32; j++) {
                x[i+j] += h[i] * d[j];
            }
        }
        var range = sm.ToList().GetRange(32, sm.Length - 32).ToArray();
        ModL(range, x);
        for (var k = 0; k < range.Length; k++) sm[k + 32] = range[k];
        return smlen;
    }
    public static byte[] Sign(byte[] msg, byte[] secretKey)
    {
        if (secretKey.Length != crypto_sign_SECRETKEYBYTES)
            throw new Exception("bad secret key size");
        var signedMsg = new byte[crypto_sign_BYTES+msg.Length];
        CryptoSign(signedMsg, msg, msg.Length, secretKey);
        return signedMsg;
    }

    public static byte[] Detached(byte[] msg, byte[] secretKey)
    {
        var signedMsg = Sign(msg, secretKey);

        var sig = new byte[crypto_sign_BYTES];
        for (var i = 0; i < sig.Length; i++)
            sig[i] = signedMsg[i];
        return sig;
    }

    public static int Unpackneg(long[][] r, byte[] p)
    {
        var t = NaclCatapult.Gf(); var chk = NaclCatapult.Gf(); var num = NaclCatapult.Gf();
        var den = NaclCatapult.Gf(); var den2 = NaclCatapult.Gf(); var den4 = NaclCatapult.Gf();
        var den6 = NaclCatapult.Gf();

        NaclCatapult.Set25519(r[2], gf1);
        NaclCatapult.Unpack25519(r[1], p);
        NaclCatapult.S(num, r[1]);
        NaclCatapult.M(den, num, D);
        NaclCatapult.Z(num, num, r[2]);
        NaclCatapult.A(den, r[2], den);

        NaclCatapult.S(den2, den);
        NaclCatapult.S(den4, den2);
        NaclCatapult.M(den6, den4, den2);
        NaclCatapult.M(t, den6, num);
        NaclCatapult.M(t, t, den);

        NaclCatapult.Pow2523(t, t);
        NaclCatapult.M(t, t, num);
        NaclCatapult.M(t, t, den);
        NaclCatapult.M(t, t, den);
        NaclCatapult.M(r[0], t, den);

        NaclCatapult.S(chk, r[0]);
        NaclCatapult.M(chk, chk, den);
        if (NaclCatapult.Neq25519(chk, num) != 0)
            NaclCatapult.M(r[0], r[0], I);

        NaclCatapult.S(chk, r[0]);
        NaclCatapult.M(chk, chk, den);
        if (NaclCatapult.Neq25519(chk, num) != 0)
            return -1;

        if (NaclCatapult.Par25519(r[0]) == (p[31] >> 7))
            NaclCatapult.Z(r[0], gf0, r[0]);

        NaclCatapult.M(r[3], r[0], r[1]);
        return 0;
    }
    public static int CryptoSignOpen(byte[] m, byte[] sm, int n, byte[] pk)
    {
        int i;
        long[] t = new long[32]; byte[] h = new byte[64];
        var p = new[] {NaclCatapult.Gf(), NaclCatapult.Gf(), NaclCatapult.Gf(), NaclCatapult.Gf()};
        var q = new[] {NaclCatapult.Gf(), NaclCatapult.Gf(), NaclCatapult.Gf(), NaclCatapult.Gf()};
        
        if (64 > n)
            return -1;
        
        if (Unpackneg(q, pk) != 0)
            return -1;
        
        for (i = 0; i < n; i++)
            m[i] = sm[i];
        for (i = 0; 32 > i; i++)
            m[i + 32] = pk[i];

        CryptoHash(h, m, n);
        Reduce(h);
        NaclCatapult.Scalarmult(p, q, h);
        
        ScalarBase(q, sm.ToList().GetRange(32, sm.Length - 32).ToArray());
        NaclCatapult.Add(p, q);
        NaclCatapult.Pack(t, p);
        n -= 64;
        var longArr = new long[sm.Length];
        for (var k = 0; k < longArr.Length; k++)
            longArr[k] = sm[k];
        
        if (NaclCatapult.CryptoVerify32(longArr, 0, t, 0) != 0) {
            for (i = 0; i < n; i++)
                m[i] = 0;
            return -1;
        }
        for (var k = 0; k < longArr.Length; k++)
            sm[k] = (byte)longArr[k];

        for (i = 0; i < n; i++)
            m[i] = sm[i + 64];
        return n;
    }

    public static bool Verify(byte[] msg, byte[] sig, byte[] publicKey)
    {
        if (sig.Length != crypto_sign_BYTES)
            throw new Exception("bad signature size");
        if (publicKey.Length != crypto_sign_PUBLICKEYBYTES)
            throw new Exception("bad public key size");
        var sm = new byte[crypto_sign_BYTES + msg.Length];
        var m = new byte[crypto_sign_BYTES + msg.Length];
        int i;
        for (i = 0; i < crypto_sign_BYTES; i++)
            sm[i] = sig[i];
        for (i = 0; i < msg.Length; i++)
            sm[i + crypto_sign_BYTES] = msg[i];
        return 0 <= CryptoSignOpen(m, sm, sm.Length, publicKey);
    }
    
    static long[] gf0 = NaclCatapult.Gf(),
        gf1 = NaclCatapult.Gf(new long[]{1}),
        _121665 = NaclCatapult.Gf(new long[]{0xdb41, 1}),
        D = NaclCatapult.Gf(new long[]{0x78a3, 0x1359, 0x4dca, 0x75eb, 0xd8ab, 0x4141, 0x0a4d, 0x0070, 0xe898, 0x7779, 0x4079, 0x8cc7, 0xfe73, 0x2b6f, 0x6cee, 0x5203}),
        D2 = NaclCatapult.Gf(new long[]{0xf159, 0x26b2, 0x9b94, 0xebd6, 0xb156, 0x8283, 0x149a, 0x00e0, 0xd130, 0xeef3, 0x80f2, 0x198e, 0xfce7, 0x56df, 0xd9dc, 0x2406}),
        X = NaclCatapult.Gf(new long[]{0xd51a, 0x8f25, 0x2d60, 0xc956, 0xa7b2, 0x9525, 0xc760, 0x692c, 0xdc5c, 0xfdd6, 0xe231, 0xc0a4, 0x53fe, 0xcd6e, 0x36d3, 0x2169}),
        Y = NaclCatapult.Gf(new long[]{0x6658, 0x6666, 0x6666, 0x6666, 0x6666, 0x6666, 0x6666, 0x6666, 0x6666, 0x6666, 0x6666, 0x6666, 0x6666, 0x6666, 0x6666, 0x6666}),
        I = NaclCatapult.Gf(new long[]{0xa0b0, 0x4a0e, 0x1b27, 0xc4ee, 0xe478, 0xad2f, 0x1806, 0x2f43, 0xd7a7, 0x3dfb, 0x0099, 0x2b4d, 0xdf0b, 0x4fc1, 0x2480, 0x2b83});

    const int crypto_secretbox_KEYBYTES = 32,
        crypto_secretbox_NONCEBYTES = 24,
        crypto_secretbox_ZEROBYTES = 32,
        crypto_secretbox_BOXZEROBYTES = 16,
        crypto_scalarmult_BYTES = 32,
        crypto_scalarmult_SCALARBYTES = 32,
        crypto_box_PUBLICKEYBYTES = 32,
        crypto_box_SECRETKEYBYTES = 32,
        crypto_box_BEFORENMBYTES = 32,
        crypto_box_NONCEBYTES = crypto_secretbox_NONCEBYTES,
        crypto_box_ZEROBYTES = crypto_secretbox_ZEROBYTES,
        crypto_box_BOXZEROBYTES = crypto_secretbox_BOXZEROBYTES,
        crypto_sign_BYTES = 64,
        crypto_sign_PUBLICKEYBYTES = 32,
        crypto_sign_SECRETKEYBYTES = 64,
        crypto_sign_SEEDBYTES = 32,
        crypto_hash_BYTES = 64;
}

}