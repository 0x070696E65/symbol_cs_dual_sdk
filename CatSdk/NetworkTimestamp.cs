using System.Numerics;

namespace CatSdk
{
    public class NetworkTimestamp
    {
        public BigInteger Timestamp;

        public NetworkTimestamp(BigInteger timestamp)
        {
            Timestamp = timestamp;
        }
    }

    public class NetworkTimestampDatetimeConverter
    {
        public DateTime Epoc;
        public int TimeUnits;

        public NetworkTimestampDatetimeConverter(DateTime epoc, string timeUnits)
        {
            Epoc = epoc;
            TimeUnits = GetTimeUnits(timeUnits);
        }

        private int GetTimeUnits(string timeUnits)
        {
            return timeUnits switch
            {
                "hours" => 60 * 60 * 1000,
                "mimnutes" => 60 * 1000,
                "seconds" => 1000,
                "milliseconds" => 1,
                _ => 1
            };
        } 
    }
}
