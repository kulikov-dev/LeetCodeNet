namespace LeetCodeNet.Medium.Design
{
    /// <summary>
    /// https://leetcode.com/problems/frequency-tracker/
    /// </summary>
    /// <remarks>
    /// Design a data structure that keeps track of the values in it and answers some queries regarding their frequencies.
    /// Implement the FrequencyTracker class.
    /// FrequencyTracker() : Initializes the FrequencyTracker object with an empty array initially.
    /// void add(int number): Adds number to the data structure.
    /// void deleteOne(int number): Deletes one occurence of number from the data structure.The data structure may not contain number, and in this case nothing is deleted.
    /// bool hasFrequency(int frequency): Returns true if there is a number in the data structure that occurs frequency number of times, otherwise, it returns false.
    /// </remarks>
    public class FrequencyTracker
    {
        //// The idea is to have two dictionaries: one to count the frequency of each number and the other to store information about frequencies.
        /// When we add a new number, we increase its frequency as well as the number of numbers with this frequency.
        /// When we remove a number, we decrease its frequency, decrease the amount for the old frequency, and increase the amount for the new frequency.
        /// For checking 'hasFrequency' we just need to check if our frequency dictionary contains this value.

        /// <summary>
        /// Dict of frequencies
        /// </summary>
        /// <remarks>
        /// Key: Frequency
        /// Value: Amount of numbers with this frequency
        /// </remarks>
        private readonly Dictionary<int, int> _frequenciesDict;

        /// <summary>
        /// Dict of numbers
        /// </summary>
        /// <remarks>
        /// Key: Number
        /// Value: Frequency of this number
        /// </remarks>
        private readonly Dictionary<int, int> _numsDict;

        /// <summary>
        /// Constructor
        /// </summary>
        public FrequencyTracker()
        {
            _numsDict = new Dictionary<int, int>();
            _frequenciesDict = new Dictionary<int, int>();
        }

        /// <summary>
        /// Adds number to the data structure
        /// </summary>
        /// <param name="number"> Number </param>
        public void Add(int number)
        {
            if (!_numsDict.ContainsKey(number))
            {
                _numsDict.Add(number, 0);
            }

            if (_frequenciesDict.ContainsKey(_numsDict[number]) && _numsDict[number] > 0)
            {
                _frequenciesDict[_numsDict[number]]--;
            }

            _numsDict[number]++;

            if (!_frequenciesDict.ContainsKey(_numsDict[number]))
            {
                _frequenciesDict.Add(_numsDict[number], 0);
            }

            _frequenciesDict[_numsDict[number]]++;
        }

        /// <summary>
        /// Deletes one occurrence of number from the data structure
        /// </summary>
        /// <param name="number"> Number </param>
        public void DeleteOne(int number)
        {
            if (!_numsDict.ContainsKey(number) || _numsDict[number] == 0)
            {
                return;
            }

            _frequenciesDict[_numsDict[number]]--;

            _numsDict[number]--;

            if (_numsDict[number] == 0)
            {
                return;
            }

            if (!_frequenciesDict.ContainsKey(_numsDict[number]))
            {
                _frequenciesDict.Add(_numsDict[number], 0);
            }

            _frequenciesDict[_numsDict[number]]++;
        }

        /// <summary>
        /// Returns true if there is a number in the data structure that occurs frequency number of times
        /// </summary>
        /// <param name="frequency"> Frequency </param>
        /// <returns> True if there is a number in the data structure that occurs frequency number of times </returns>
        public bool HasFrequency(int frequency)
        {
            return _frequenciesDict.ContainsKey(frequency) && _frequenciesDict[frequency] > 0;
        }
    }
}
