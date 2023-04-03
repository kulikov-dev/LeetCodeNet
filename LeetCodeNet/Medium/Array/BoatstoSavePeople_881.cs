namespace LeetCodeNet.Medium.Array
{
    /// <summary>
    /// https://leetcode.com/problems/boats-to-save-people/
    /// </summary>
    internal sealed class BoatstoSavePeople_881
    {
        /// <summary>
        /// We can apply two pointers approach with understanding of lightest & heaviest person should go together.
        /// if sum of lightest & heaviest person are under limit then both can go together , updating both pointers .
        /// If sum exceeds the limit, then heaviest person will go alone, hence updating only the rightPointer.
        /// Below is my first approach which can be easily used in task modification without limit persons-per-boat.
        /// Great explanation with pictures <see cref="https://leetcode.com/problems/boats-to-save-people/solutions/1877945/java-c-a-very-easy-explanation-trust-me"/>
        /// </summary>
        /// <param name="people"> People & weights </param>
        /// <param name="limit"> Weights limit </param>
        /// <returns></returns>
        /// <remarks>
        /// Time complexity: O(n * log(n))
        /// Space complexity: O(1)
        /// </remarks>
        public int NumRescueBoatsSimple(int[] people, int limit)
        {
            var leftPointer = 0;
            var rightPointer = people.Length - 1;
            var result = 0;

            people = people.OrderBy(x => x).ToArray();

            while (leftPointer <= rightPointer)
            {
                var currentSum = 0;
                var passengers = 0;

                while (rightPointer >= 0 && passengers < 2 && people[rightPointer] + currentSum <= limit)
                {
                    currentSum += people[rightPointer];
                    --rightPointer;
                    passengers++;
                }

                while (leftPointer < rightPointer && passengers < 2 && people[leftPointer] + currentSum <= limit)
                {
                    currentSum += people[leftPointer];
                    ++leftPointer;
                    passengers++;
                }

                ++result;
            }

            return result;
        }

        /// <summary>
        /// Optimized solution for this task
        /// </summary>
        /// <param name="people"> People & weights </param>
        /// <param name="limit"> Weights limit </param>
        /// <returns></returns>
        /// <remarks>
        /// Time complexity: O(n * log(n))
        /// Space complexity: O()
        /// </remarks>
        public int NumRescueBoatsOptimized(int[] people, int limit)
        {
            var leftPointer = 0;
            var rightPointer = people.Length - 1;
            var result = 0;

            people = people.OrderBy(x => x).ToArray();

            while (leftPointer <= rightPointer)
            {
                ++result;
                if (people[leftPointer] + people[rightPointer] <= limit)
                {
                    ++leftPointer;
                   
                }

                --rightPointer;
            }

            return result;
        }
    }
}
