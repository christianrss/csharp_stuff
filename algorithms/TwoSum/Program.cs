using System;

namespace Algorithms
{
    sealed class Program
    {
        public static int[] findTwoSum(int[] nums, int target)
        {
            for (int p1 = 0; p1 < nums.Length; p1++)
            {
                int numberToFind = target - nums[p1];
                for (int p2 = p1+1; p2 < nums.Length; p2++)
                {
                    if (numberToFind == nums[p2])
                    {
                        return [p1,p2];
                    }
                }
            }

            return [-1,-1];
        }

        static void Main(string[] args)
        {
            int[] nums = findTwoSum([1,2,3,4,5,9], 11);
            if (nums[0] != -1 && nums[1] != -1)
            {
                Console.WriteLine($"Indices {nums[0]}, {nums[1]}\n");
            } else {
                Console.WriteLine($"No two sum solution\n");
            }
            
        }
    }
}