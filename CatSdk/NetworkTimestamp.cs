namespace CatSdk
{
    /**
     * Represents a network timestamp.
     */
    public class NetworkTimestamp
    {
        public readonly ulong Timestamp;

        /**
	     * Creates a timestamp.
	     * @param {ulong} timestamp Raw network timestamp.
	     */
        public NetworkTimestamp(ulong timestamp)
        {
            Timestamp = timestamp;
        }

        /**
	     * Determines if this is the epochal timestamp.
	     */
        public bool IsEpochal()
        {
            return 0 == Timestamp;
        }
        
        /**
	     * Adds a specified number of seconds to this timestamp.
	     * @abstract
	     * @param {ulong} count Number of seconds to add.
	     * @returns {NetworkTimestamp} New timestamp that is the specified number of seconds past this timestamp.
	     */
        public virtual NetworkTimestamp AddSeconds(ulong count) {
            throw new Exception("addSeconds be implemented by concrete class");
        }
        
        /**
		 * Adds a specified number of minutes to this timestamp.
		 * @param {ulong} count Number of minutes to add.
		 * @returns {NetworkTimestamp} New timestamp that is the specified number of minutes past this timestamp.
		 */
        public NetworkTimestamp AddMinutes(ulong count) {
            return AddSeconds(60 * count);
        }

        /**
		 * Adds a specified number of hours to this timestamp.
		 * @param {ulong} count Number of hours to add.
		 * @returns {NetworkTimestamp} New timestamp that is the specified number of hours past this timestamp.
		 */
        public NetworkTimestamp AddHours(ulong count) {
            return AddMinutes(60 * count);
        }

        /**
		 * Returns string representation of this object.
		 * @returns {string} String representation of this object
		 */
        public override string ToString() {
            return Timestamp.ToString();
        }
    }

    /**
     * Provides utilities for converting between network timestamps and datetimes.
     */
    public class NetworkTimestampDatetimeConverter
    {
        public DateTime Epoch;
        public int TimeUnits;

        /**
	     * Creates a converter given an epoch and base time units.
	     * @param {DateTime} epoch Date at which network started.
	     * @param {string} timeUnits Time unit the network uses for progressing.
	     */
        public NetworkTimestampDatetimeConverter(DateTime epoch, string timeUnits)
        {
	        Epoch = epoch;
            TimeUnits = GetTimeUnits(timeUnits);
        }

        private static int GetTimeUnits(string timeUnits)
        {
            return timeUnits switch
            {
                "hours" => 60 * 60 * 1000,
                "minutes" => 60 * 1000,
                "seconds" => 1000,
                "milliseconds" => 1,
                _ => 1
            };
        }
        
        /**
		 * Converts a network timestamp to a datetime.
		 * @param {ulong} rawTimestamp Raw network timestamp.
		 * @returns {DateTime} Date representation of the network timestamp.
		 */
        public DateTime ToDatetime(ulong rawTimestamp) {
	        return new DateTime(Epoch.Millisecond + (int)rawTimestamp * TimeUnits);
        }

        /**
		 * Subtracts the network epoch from the reference date.
		 * @param {Date} referenceDatetime Reference date.
		 * @returns {number} Number of network time units between the reference date and the network epoch.
		 */
        public ulong ToDifference(DateTime referenceDatetime) {
	        if (referenceDatetime < Epoch)
		        throw new Exception("timestamp cannot be before epoch");
	        return (ulong)((referenceDatetime - Epoch) / TimeUnits).TotalMilliseconds;
        }
    }
}