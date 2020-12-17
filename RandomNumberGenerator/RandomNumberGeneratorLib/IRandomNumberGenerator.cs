namespace RandomNumberGeneratorLib
{
    /// <summary>
    /// Random Number Generator
    /// </summary>
    public interface IRandomNumberGenerator
    {
        uint Min { get; set; }
        uint MinDefault { get; }
        uint Max { get; set; }
        uint MaxDefault { get; }

        /// <summary>
        /// Reset range to default values
        /// </summary>
        void Reset();
        /// <summary>
        /// Get a random value from a given range
        /// </summary>
        uint GetValue();
    }
}