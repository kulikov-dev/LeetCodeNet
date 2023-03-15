namespace LeetCodeNet.Easy.Array
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class FindtheHighestAltitude_1732
    {
        public int LargestAltitude(int[] gain)
        {
            var currentPoint = 0;
            var result = 0;
            for (var index = 0; index < gain.Length; index++)
            {
                var item = gain[index];

                currentPoint += item;

                result = Math.Max(result, currentPoint);
            }

            return result;
        }
    }
}
