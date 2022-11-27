using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// link to the problem: https://leetcode.com/problems/longest-continuous-increasing-subsequence/

/* Description:
 * Given an unsorted array of integers nums, return the length of the longest 
 * continuous increasing subsequence (i.e. subarray). The subsequence must be 
 * strictly increasing.
 * A continuous increasing subsequence is defined by two indices l and r (l < r) 
 * such that it is [nums[l], nums[l + 1], ..., nums[r - 1], nums[r]] and for each l <= i < r, nums[i] < nums[i + 1].
 * 
 */

public class Exercise10
{
    public int FindLengthOfLCIS(int[] nums)
    {
        List<int> counts = new List<int>();
        int count = 1;
        bool flag = false;
        if (nums.Length == 0) return 0;
        else if (nums.Length == 1) return count;
        else
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] < nums[i + 1])
                {
                    count++; // count = 3
                    flag = true;
                }
                else
                {
                    counts.Add(count);
                    count = 1;
                    flag = false;
                }
            }
        }
        if (flag) counts.Add(count);
        return counts.Max();
    }
}
