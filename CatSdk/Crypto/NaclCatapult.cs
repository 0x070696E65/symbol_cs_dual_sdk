namespace CatSdk.Crypto;

public static class NaclCatapult
{
    public static long[] Gf(long[]? init = null)
        {
            var r = new long[16];
            if (init == null) return r;
            for (var i = 0; i < init.Length; i++) {
                r[i] = init[i];
            }
            return r;
        }
    
        private static readonly long[] gf0 = Gf();
        private static readonly long[] gf1 = Gf(new long[]{1});
        private static readonly long[] D = Gf(new long[]{
            0x78a3,
            0x1359,
            0x4dca,
            0x75eb,
            0xd8ab,
            0x4141,
            0x0a4d,
            0x0070,
            0xe898,
            0x7779,
            0x4079,
            0x8cc7,
            0xfe73,
            0x2b6f,
            0x6cee,
            0x5203});
        private static readonly long[] D2 = Gf(new long[]{
            0xf159,
            0x26b2,
            0x9b94,
            0xebd6,
            0xb156,
            0x8283,
            0x149a,
            0x00e0,
            0xd130,
            0xeef3,
            0x80f2,
            0x198e,
            0xfce7,
            0x56df,
            0xd9dc,
            0x2406});
        private static long[] X = Gf(new long[]{
            0xd51a,
            0x8f25,
            0x2d60,
            0xc956,
            0xa7b2,
            0x9525,
            0xc760,
            0x692c,
            0xdc5c,
            0xfdd6,
            0xe231,
            0xc0a4,
            0x53fe,
            0xcd6e,
            0x36d3,
            0x2169});
        private static long[] Y = Gf(new long[]{
            0x6658,
            0x6666,
            0x6666,
            0x6666,
            0x6666,
            0x6666,
            0x6666,
            0x6666,
            0x6666,
            0x6666,
            0x6666,
            0x6666,
            0x6666,
            0x6666,
            0x6666,
            0x6666});
        private static readonly long[] I = Gf(new long[]{
            0xa0b0,
            0x4a0e,
            0x1b27,
            0xc4ee,
            0xe478,
            0xad2f,
            0x1806,
            0x2f43,
            0xd7a7,
            0x3dfb,
            0x0099,
            0x2b4d,
            0xdf0b,
            0x4fc1,
            0x2480,
            0x2b83});
        private static long[] L = new long[]{
            0xed,
            0xd3,
            0xf5,
            0x5c,
            0x1a,
            0x63,
            0x12,
            0x58,
            0xd6,
            0x9c,
            0xf7,
            0xa2,
            0xde,
            0xf9,
            0xde,
            0x14,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0x10};

        private static void A(long[] o, long[] a, long[] b)
        {
            for (var i = 0; i < 16; i++) { 
                o[i] = a[i] + b[i];
            }
        }

        private static void Z(long[] o, long[] a, long[] b)
        {
            for (var i = 0; i < 16; i++) { 
                o[i] = a[i] - b[i];
            }
        }

        private static void M(long[] o, long[] a, long[] b)
        {
            long v;
            long c;
            long t0 = 0;
            long t1 = 0;
            long t2 = 0;
            long t3 = 0;
            long t4 = 0;
            long t5 = 0;
            long t6 = 0;
            long t7 = 0;
            long t8 = 0;
            long t9 = 0;
            long t10 = 0;
            long t11 = 0;
            long t12 = 0;
            long t13 = 0;
            long t14 = 0;
            long t15 = 0;
            long t16 = 0;
            long t17 = 0;
            long t18 = 0;
            long t19 = 0;
            long t20 = 0;
            long t21 = 0;
            long t22 = 0;
            long t23 = 0;
            long t24 = 0;
            long t25 = 0;
            long t26 = 0;
            long t27 = 0;
            long t28 = 0;
            long t29 = 0;
            long t30 = 0;

            var b0 = b[0];
            var b1 = b[1];
            var b2 = b[2];
            var b3 = b[3];
            var b4 = b[4];
            var b5 = b[5];
            var b6 = b[6];
            var b7 = b[7];
            var b8 = b[8];
            var b9 = b[9];
            var b10 = b[10];
            var b11 = b[11];
            var b12 = b[12];
            var b13 = b[13];
            var b14 = b[14];
            var b15 = b[15];
            
            v = a[0];
            t0 += v * b0;
            t1 += v * b1;
            t2 += v * b2;
            t3 += v * b3;
            t4 += v * b4;
            t5 += v * b5;
            t6 += v * b6;
            t7 += v * b7;
            t8 += v * b8;
            t9 += v * b9;
            t10 += v * b10;
            t11 += v * b11;
            t12 += v * b12;
            t13 += v * b13;
            t14 += v * b14;
            t15 += v * b15;
            v = a[1];
            t1 += v * b0;
            t2 += v * b1;
            t3 += v * b2;
            t4 += v * b3;
            t5 += v * b4;
            t6 += v * b5;
            t7 += v * b6;
            t8 += v * b7;
            t9 += v * b8;
            t10 += v * b9;
            t11 += v * b10;
            t12 += v * b11;
            t13 += v * b12;
            t14 += v * b13;
            t15 += v * b14;
            t16 += v * b15;
            v = a[2];
            t2 += v * b0;
            t3 += v * b1;
            t4 += v * b2;
            t5 += v * b3;
            t6 += v * b4;
            t7 += v * b5;
            t8 += v * b6;
            t9 += v * b7;
            t10 += v * b8;
            t11 += v * b9;
            t12 += v * b10;
            t13 += v * b11;
            t14 += v * b12;
            t15 += v * b13;
            t16 += v * b14;
            t17 += v * b15;
            v = a[3];
            t3 += v * b0;
            t4 += v * b1;
            t5 += v * b2;
            t6 += v * b3;
            t7 += v * b4;
            t8 += v * b5;
            t9 += v * b6;
            t10 += v * b7;
            t11 += v * b8;
            t12 += v * b9;
            t13 += v * b10;
            t14 += v * b11;
            t15 += v * b12;
            t16 += v * b13;
            t17 += v * b14;
            t18 += v * b15;
            v = a[4];
            t4 += v * b0;
            t5 += v * b1;
            t6 += v * b2;
            t7 += v * b3;
            t8 += v * b4;
            t9 += v * b5;
            t10 += v * b6;
            t11 += v * b7;
            t12 += v * b8;
            t13 += v * b9;
            t14 += v * b10;
            t15 += v * b11;
            t16 += v * b12;
            t17 += v * b13;
            t18 += v * b14;
            t19 += v * b15;
            v = a[5];
            t5 += v * b0;
            t6 += v * b1;
            t7 += v * b2;
            t8 += v * b3;
            t9 += v * b4;
            t10 += v * b5;
            t11 += v * b6;
            t12 += v * b7;
            t13 += v * b8;
            t14 += v * b9;
            t15 += v * b10;
            t16 += v * b11;
            t17 += v * b12;
            t18 += v * b13;
            t19 += v * b14;
            t20 += v * b15;
            v = a[6];
            t6 += v * b0;
            t7 += v * b1;
            t8 += v * b2;
            t9 += v * b3;
            t10 += v * b4;
            t11 += v * b5;
            t12 += v * b6;
            t13 += v * b7;
            t14 += v * b8;
            t15 += v * b9;
            t16 += v * b10;
            t17 += v * b11;
            t18 += v * b12;
            t19 += v * b13;
            t20 += v * b14;
            t21 += v * b15;
            v = a[7];
            t7 += v * b0;
            t8 += v * b1;
            t9 += v * b2;
            t10 += v * b3;
            t11 += v * b4;
            t12 += v * b5;
            t13 += v * b6;
            t14 += v * b7;
            t15 += v * b8;
            t16 += v * b9;
            t17 += v * b10;
            t18 += v * b11;
            t19 += v * b12;
            t20 += v * b13;
            t21 += v * b14;
            t22 += v * b15;
            v = a[8];
            t8 += v * b0;
            t9 += v * b1;
            t10 += v * b2;
            t11 += v * b3;
            t12 += v * b4;
            t13 += v * b5;
            t14 += v * b6;
            t15 += v * b7;
            t16 += v * b8;
            t17 += v * b9;
            t18 += v * b10;
            t19 += v * b11;
            t20 += v * b12;
            t21 += v * b13;
            t22 += v * b14;
            t23 += v * b15;
            v = a[9];
            t9 += v * b0;
            t10 += v * b1;
            t11 += v * b2;
            t12 += v * b3;
            t13 += v * b4;
            t14 += v * b5;
            t15 += v * b6;
            t16 += v * b7;
            t17 += v * b8;
            t18 += v * b9;
            t19 += v * b10;
            t20 += v * b11;
            t21 += v * b12;
            t22 += v * b13;
            t23 += v * b14;
            t24 += v * b15;
            v = a[10];
            t10 += v * b0;
            t11 += v * b1;
            t12 += v * b2;
            t13 += v * b3;
            t14 += v * b4;
            t15 += v * b5;
            t16 += v * b6;
            t17 += v * b7;
            t18 += v * b8;
            t19 += v * b9;
            t20 += v * b10;
            t21 += v * b11;
            t22 += v * b12;
            t23 += v * b13;
            t24 += v * b14;
            t25 += v * b15;
            v = a[11];
            t11 += v * b0;
            t12 += v * b1;
            t13 += v * b2;
            t14 += v * b3;
            t15 += v * b4;
            t16 += v * b5;
            t17 += v * b6;
            t18 += v * b7;
            t19 += v * b8;
            t20 += v * b9;
            t21 += v * b10;
            t22 += v * b11;
            t23 += v * b12;
            t24 += v * b13;
            t25 += v * b14;
            t26 += v * b15;
            v = a[12];
            t12 += v * b0;
            t13 += v * b1;
            t14 += v * b2;
            t15 += v * b3;
            t16 += v * b4;
            t17 += v * b5;
            t18 += v * b6;
            t19 += v * b7;
            t20 += v * b8;
            t21 += v * b9;
            t22 += v * b10;
            t23 += v * b11;
            t24 += v * b12;
            t25 += v * b13;
            t26 += v * b14;
            t27 += v * b15;
            v = a[13];
            t13 += v * b0;
            t14 += v * b1;
            t15 += v * b2;
            t16 += v * b3;
            t17 += v * b4;
            t18 += v * b5;
            t19 += v * b6;
            t20 += v * b7;
            t21 += v * b8;
            t22 += v * b9;
            t23 += v * b10;
            t24 += v * b11;
            t25 += v * b12;
            t26 += v * b13;
            t27 += v * b14;
            t28 += v * b15;
            v = a[14];
            t14 += v * b0;
            t15 += v * b1;
            t16 += v * b2;
            t17 += v * b3;
            t18 += v * b4;
            t19 += v * b5;
            t20 += v * b6;
            t21 += v * b7;
            t22 += v * b8;
            t23 += v * b9;
            t24 += v * b10;
            t25 += v * b11;
            t26 += v * b12;
            t27 += v * b13;
            t28 += v * b14;
            t29 += v * b15;
            v = a[15];
            t15 += v * b0;
            t16 += v * b1;
            t17 += v * b2;
            t18 += v * b3;
            t19 += v * b4;
            t20 += v * b5;
            t21 += v * b6;
            t22 += v * b7;
            t23 += v * b8;
            t24 += v * b9;
            t25 += v * b10;
            t26 += v * b11;
            t27 += v * b12;
            t28 += v * b13;
            t29 += v * b14;
            t30 += v * b15;

            t0 += 38 * t16;
            t1 += 38 * t17;
            t2 += 38 * t18;
            t3 += 38 * t19;
            t4 += 38 * t20;
            t5 += 38 * t21;
            t6 += 38 * t22;
            t7 += 38 * t23;
            t8 += 38 * t24;
            t9 += 38 * t25;
            t10 += 38 * t26;
            t11 += 38 * t27;
            t12 += 38 * t28;
            t13 += 38 * t29;
            t14 += 38 * t30;
            // t15 left as is
            
            // first car
            c = 1;
            v = t0 + c + 65535;
            c = Convert.ToInt64(Math.Floor((double)v / 65536));
            t0 = v - c * 65536;
            v = t1 + c + 65535;
            c = Convert.ToInt64(Math.Floor((double)v / 65536));
            t1 = v - c * 65536;
            v = t2 + c + 65535;
            c = Convert.ToInt64(Math.Floor((double)v / 65536));
            t2 = v - c * 65536;
            v = t3 + c + 65535;
            c = Convert.ToInt64(Math.Floor((double)v / 65536));
            t3 = v - c * 65536;
            v = t4 + c + 65535;
            c = Convert.ToInt64(Math.Floor((double)v / 65536));
            t4 = v - c * 65536;
            v = t5 + c + 65535;
            c = Convert.ToInt64(Math.Floor((double)v / 65536));
            t5 = v - c * 65536;
            v = t6 + c + 65535;
            c = Convert.ToInt64(Math.Floor((double)v / 65536));
            t6 = v - c * 65536;
            v = t7 + c + 65535;
            c = Convert.ToInt64(Math.Floor((double)v / 65536));
            t7 = v - c * 65536;
            v = t8 + c + 65535;
            c = Convert.ToInt64(Math.Floor((double)v / 65536));
            t8 = v - c * 65536;
            v = t9 + c + 65535;
            c = Convert.ToInt64(Math.Floor((double)v / 65536));
            t9 = v - c * 65536;
            v = t10 + c + 65535;
            c = Convert.ToInt64(Math.Floor((double)v / 65536));
            t10 = v - c * 65536;
            v = t11 + c + 65535;
            c = Convert.ToInt64(Math.Floor((double)v / 65536));
            t11 = v - c * 65536;
            v = t12 + c + 65535;
            c = Convert.ToInt64(Math.Floor((double)v / 65536));
            t12 = v - c * 65536;
            v = t13 + c + 65535;
            c = Convert.ToInt64(Math.Floor((double)v / 65536));
            t13 = v - c * 65536;
            v = t14 + c + 65535;
            c = Convert.ToInt64(Math.Floor((double)v / 65536));
            t14 = v - c * 65536;
            v = t15 + c + 65535;
            c = Convert.ToInt64(Math.Floor((double)v / 65536));
            t15 = v - c * 65536;
            t0 += c - 1 + 37 * (c - 1);

            // second car
            c = 1;
            v = t0 + c + 65535;
            c = Convert.ToInt64(Math.Floor((double)v / 65536));
            t0 = v - c * 65536;
            v = t1 + c + 65535;
            c = Convert.ToInt64(Math.Floor((double)v / 65536));
            t1 = v - c * 65536;
            v = t2 + c + 65535;
            c = Convert.ToInt64(Math.Floor((double)v / 65536));
            t2 = v - c * 65536;
            v = t3 + c + 65535;
            c = Convert.ToInt64(Math.Floor((double)v / 65536));
            t3 = v - c * 65536;
            v = t4 + c + 65535;
            c = Convert.ToInt64(Math.Floor((double)v / 65536));
            t4 = v - c * 65536;
            v = t5 + c + 65535;
            c = Convert.ToInt64(Math.Floor((double)v / 65536));
            t5 = v - c * 65536;
            v = t6 + c + 65535;
            c = Convert.ToInt64(Math.Floor((double)v / 65536));
            t6 = v - c * 65536;
            v = t7 + c + 65535;
            c = Convert.ToInt64(Math.Floor((double)v / 65536));
            t7 = v - c * 65536;
            v = t8 + c + 65535;
            c = Convert.ToInt64(Math.Floor((double)v / 65536));
            t8 = v - c * 65536;
            v = t9 + c + 65535;
            c = Convert.ToInt64(Math.Floor((double)v / 65536));
            t9 = v - c * 65536;
            v = t10 + c + 65535;
            c = Convert.ToInt64(Math.Floor((double)v / 65536));
            t10 = v - c * 65536;
            v = t11 + c + 65535;
            c = Convert.ToInt64(Math.Floor((double)v / 65536));
            t11 = v - c * 65536;
            v = t12 + c + 65535;
            c = Convert.ToInt64(Math.Floor((double)v / 65536));
            t12 = v - c * 65536;
            v = t13 + c + 65535;
            c = Convert.ToInt64(Math.Floor((double)v / 65536));
            t13 = v - c * 65536;
            v = t14 + c + 65535;
            c = Convert.ToInt64(Math.Floor((double)v / 65536));
            t14 = v - c * 65536;
            v = t15 + c + 65535;
            c = Convert.ToInt64(Math.Floor((double)v / 65536));
            t15 = v - c * 65536;
            t0 += c - 1 + 37 * (c - 1);

            o[0] = t0;
            o[1] = t1;
            o[2] = t2;
            o[3] = t3;
            o[4] = t4;
            o[5] = t5;
            o[6] = t6;
            o[7] = t7;
            o[8] = t8;
            o[9] = t9;
            o[10] = t10;
            o[11] = t11;
            o[12] = t12;
            o[13] = t13;
            o[14] = t14;
            o[15] = t15;
        }

        private static void S(long[] o, long[] a)
        {
            M(o, a, a);
        }
        
        private static long Vn(long[] x, int xi, long[] y, int yi, int n)
        {
            long d = 0;
            for (var i = 0; i < n; i++) {
                d |= x[xi + i] ^ y[yi + i];
            }
            return (1 & ((d - 1) >> 8)) - 1;
        }
        
        private static void Pow2523(long[] o, long[] i)
        {
            var c = Gf();
            for (var a = 0; a < 16; a++) {
                c[a] = i[a];
            }
            for (var a = 250; a >= 0; a--) {
                S(c, c);
                if (a != 1) {
                    M(c, c, i);
                }
            }
            for (var a = 0; a < 16; a++) {
                o[a] = c[a];
            }
        }
        
        private static void Inv25519(long[] o, long[] i)
        {
            var c = Gf();
            for (var a = 0; a < 16; a++) {
                c[a] = i[a];
            }
            for (var a = 253; a >= 0; a--) {
                S(c, c);
                if (a != 2 && a != 4) {
                    M(c, c, i);
                }
            }
            for (var a = 0; a < 16; a++) {
                o[a] = c[a];
            }
        }
        
        private static void Set25519(long[] r, long[] a)
        {
            for (var i = 0; i < 16; i++) {
                r[i] = a[i] | 0;
            }
        }
        
        private static void Car25519(long[] o)
        {
            long c = 1;
            for (var i = 0; i < 16; i++) {
                var v = o[i] + c + 65535;
                c = Convert.ToInt64(Math.Floor((double)v / 65536));
                o[i] = v - c * 65536;
            }
            o[0] += c - 1 + 37 * (c - 1);
        }
        
        private static void Sel25519(long[] p, long[] q, long b)
        {
            var c = ~(b - 1);
            for (var i = 0; i < 16; i++) {
                var t = c & (p[i] ^ q[i]);
                p[i] ^= t;
                q[i] ^= t;
            }
        }
        
        private static void Pack25519(long[] o, long[] n)
        {
            var m = Gf();
            var t = Gf();
            for (var i = 0; i < 16; i++) {
                t[i] = n[i];
            }
            Car25519(t);
            Car25519(t);
            Car25519(t);
            for (var j = 0; j < 2; j++) {
                m[0] = t[0] - 0xffed;
                for (var i = 1; i < 15; i++) {
                    m[i] = t[i] - 0xffff - ((m[i - 1] >> 16) & 1);
                    m[i - 1] &= 0xffff;
                }
                m[15] = t[15] - 0x7fff - ((m[14] >> 16) & 1);
                var b = (m[15] >> 16) & 1;
                m[14] &= 0xffff;
                Sel25519(t, m, 1 - b);
            }
            for (var i = 0; i < 16; i++) {
                o[2 * i] = t[i] & 0xff;
                o[2 * i + 1] = t[i] >> 8;
            }
        }

        private static void Cswap(long[][] p, long[][] q, long b)
        {
            for (var i = 0; i < 4; i++)
            {
                Sel25519(p[i], q[i], b);
            }
        }
        
        private static long Neq25519(long[] a, long[] b)
        {
            var c = new long[32];
            var d = new long[32];
            Pack25519(c, a);
            Pack25519(d, b);
            return CryptoVerify32(c, 0, d, 0);
        }
        
        public static long CryptoVerify32(long[] x, int xi, long[] y, int yi)
        {
            return Vn(x, xi, y, yi, 32);
        }
        
        private static long Par25519(long[] a)
        {
            var d = new long[32];
            Pack25519(d, a);
            return d[0] & 1;
        }
        
        private static void Unpack25519(long[] o, byte[] n)
        {
            for (var i = 0; i < 16; i++) {
                o[i] = n[2 * i] + (long)(n[2 * i + 1] << 8);
            }
            o[15] &= 0x7fff;
        }

        private static void Add(IReadOnlyList<long[]> p, IReadOnlyList<long[]> q)
        {
            var a = Gf();
            var b = Gf();
            var c = Gf();
            var d = Gf();
            var e = Gf();
            var f = Gf();
            var g = Gf();
            var h = Gf();
            var t = Gf();

            Z(a, p[1], p[0]);
            Z(t, q[1], q[0]);
            M(a, a, t);
            A(b, p[0], p[1]);
            A(t, q[0], q[1]);
            M(b, b, t);
            M(c, p[3], q[3]);
            M(c, c, D2);
            M(d, p[2], q[2]);
            A(d, d, d);
            Z(e, b, a);
            Z(f, d, c);
            A(g, d, c);
            A(h, b, a);

            M(p[0], e, f);
            M(p[1], h, g);
            M(p[2], g, f);
            M(p[3], e, h);
        }

        public static void Pack(long[] r, long[][] p)
        {
            var tx = Gf();
            var ty = Gf();
            var zi = Gf();
            Inv25519(zi, p[2]);
            M(tx, p[0], zi);
            M(ty, p[1], zi);
            Pack25519(r, ty);
            r[31] ^= Par25519(tx) << 7;
        }

        public static void Scalarmult(long[][] p, long[][] q, byte[] s)
        {
            Set25519(p[0], gf0);
            Set25519(p[1], gf1);
            Set25519(p[2], gf1);
            Set25519(p[3], gf0);
            for (var i = 255; i >= 0; --i) {
                var b = ((long)s[(i / 8) | 0] >> (i & 7)) & 1;
                Cswap(p, q, b);
                Add(q, p);
                Add(p, p);
                Cswap(p, q, b);
            }
        }

        public static int Unpack(long[][] r, byte[] p)
        {
            var t = Gf();
            var chk = Gf();
            var num = Gf();
            var den = Gf();
            var den2 = Gf();
            var den4 = Gf();
            var den6 = Gf();

            Set25519(r[2], gf1);
            Unpack25519(r[1], p);
            
            // num = u = y^2 - 1
            // den = v = d * y^2 + 1
            S(num, r[1]);
            M(den, num, D);
            Z(num, num, r[2]);
            A(den, r[2], den);
            
            // r[0] = x = sqrt(u / v)
            S(den2, den);
            S(den4, den2);
            M(den6, den4, den2);
            M(t, den6, num);
            M(t, t, den);

            Pow2523(t, t);
            M(t, t, num);
            M(t, t, den);
            M(t, t, den);
            
            M(r[0], t, den);

            S(chk, r[0]);
            M(chk, chk, den);
            if (Neq25519(chk, num) != 0) {
                M(r[0], r[0], I);
            }
            
            S(chk, r[0]);
            M(chk, chk, den);
            if (Neq25519(chk, num) != 0) {
                return -1;
            }

            if (Par25519(r[0]) != p[31] >> 7) {
                Z(r[0], gf0, r[0]);
            }

            M(r[3], r[0], r[1]);
            return 0;
        }
}