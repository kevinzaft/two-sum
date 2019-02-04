using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace two_sum
{
    class Program
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var dic = new Dictionary<int, List<int>>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                {
                    dic[nums[i]].Add(i);
                }
                else
                {
                    dic.Add(nums[i], new List<int>() { i });
                }

            }
            for (int i = 0; i < nums.Length; i++)
            {
                var dif = target - nums[i];
                try
                {
                    if (dic[dif].First() != i)
                    {
                        return new int[] { i, dic[dif].First() };
                    }
                    else if (dic[dif].Count() > 1)
                    {
                        return new int[] { i, dic[dif][1] };
                    }
                }
                catch
                {
                    continue;
                }
            }
            return new int[] { -1, -1 };
        }
        static void Main(string[] args)
        {
        }
    }
}
