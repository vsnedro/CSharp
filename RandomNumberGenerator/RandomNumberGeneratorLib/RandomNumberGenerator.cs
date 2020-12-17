using System;

namespace RandomNumberGeneratorLib
{
    /// <summary>
    /// Random Number Generator
    /// </summary>
    public class RandomNumberGenerator : IRandomNumberGenerator
    {
        public uint MinDefault { get; } = 1;
        public uint MaxDefault { get; } = 100;

        private uint _min;
        private uint _max;

        public uint Min
        {
            get => _min;
            set
            {
                _min = value;
                if (_min >= _max)
                {
                    _max = _min + 1;
                }
            }
        }
        public uint Max
        {
            get => _max;
            set => _max = _min >= value ? _min + 1 : value;
        }

        /// <summary>
        /// Randomizer
        /// </summary>
        private Random _random;

        /// <summary>
        /// Constructor
        /// </summary>
        public RandomNumberGenerator()
        {
            Reset();
        }

        /// <summary>
        /// Reset range to default values
        /// </summary>
        public void Reset()
        {
            _min = MinDefault;
            _max = MaxDefault;
            _random = new Random();
        }

        /// <summary>
        /// Get a random value from a given range
        /// </summary>
        public uint GetValue()
        {
            return (uint)_random.Next((int)_min, (int)_max + 1);
        }
    }
}