namespace LeetCode.Src.Problems
{
    /*
     * https://leetcode.com/problems/3sum/
     */
    internal class TripletsSumSolution : Solution
    {
        public void Run()
        {
            Console.WriteLine("Nums=?,?,?");
            int[] nums = Console.ReadLine()
                .Split(',')
                .Where(str => !string.IsNullOrEmpty(str))
                .Select(int.Parse)
                .ToArray();
            foreach (var triplet in Solve(nums))
            {
                Console.WriteLine(string.Join(",", triplet));
            }
        }

        internal IList<IList<int>> Solve(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            Array.Sort(nums);
            for (int i = 0; i < nums.Length && nums[i] <= 0; i++)
            {
                int target = -nums[i];
                int minIndex = i + 1;
                int maxIndex = nums.Length - 1;
                while (minIndex < maxIndex)
                {
                    int sum = nums[minIndex] + nums[maxIndex];
                    if (sum == target)
                    {
                        result.Add(new[] { -target, nums[minIndex], nums[maxIndex] });
                        while (minIndex < maxIndex && nums[minIndex] == nums[++minIndex]) ;
                        while (minIndex < maxIndex && nums[maxIndex] == nums[--maxIndex]) ;
                    }
                    else if (sum < target)
                        minIndex++;
                    else
                        maxIndex--;
                }
                for (; i + 1 < nums.Length && nums[i + 1] == nums[i]; i++) ;
            }
            return result;
        }

        internal IList<IList<int>> SolveWithUseHashSet(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            Array.Sort(nums);
            HashSet<int> numsSet = new(nums);
            int lastX = int.MinValue, lastY, i, j, thirdElement;
            for (i = 0; i < nums.Length && nums[i] <= 0; i++)
            {
                if (nums[i] <= lastX)
                {
                    continue;
                }
                lastY = int.MinValue;
                for (j = i + 1; j < nums.Length; j++)
                {
                    thirdElement = -(nums[i] + nums[j]);
                    if (lastY != nums[j] && numsSet.Contains(thirdElement) &&
                        (thirdElement > nums[j] ||
                        (thirdElement == nums[j] && j + 1 < nums.Length && nums[j] == nums[j + 1])))
                    {
                        result.Add(new[] { nums[i], nums[j], thirdElement });
                        lastX = nums[i];
                        lastY = nums[j];
                    }
                }
            }
            return result;
        }
    }
}