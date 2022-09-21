namespace CatSdk;

/**
 * Represents a network timestamp.
 */
public class NetworkTimestamp
{
    public ulong Timestamp;

    /**
	 * Creates a timestamp.
	 * @param {ulong} timestamp Raw network timestamp.
	 */
    public NetworkTimestamp(ulong timestamp)
    {
        Timestamp = timestamp;
    }
}

/**
 * Provides utilities for converting between network timestamps and datetimes.
 */
public class NetworkTimestampDatetimeConverter
{
    public DateTime Epoc;
    public int TimeUnits;

    /**
	 * Creates a converter given an epoch and base time units.
	 * @param {DateTime} epoch Date at which network started.
	 * @param {string} timeUnits Time unit the network uses for progressing.
	 */
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