using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// link to the problem: https://leetcode.com/problems/majority-element/

/*
 * The majority element is the element that appears more than ⌊n / 2⌋ times.
 * You may assume that the majority element always exists in the array.
 */

public class Exercise4
{
    public int MajorityElement(int[] nums)
    {
        Dictionary<int, int> majority = new Dictionary<int, int>();
        int _majority = 159999;
        for (int i = 0; i < nums.Length; i++)
        {

            if (!majority.ContainsKey(nums[i]))
            {
                majority.Add(nums[i], 1);
            }
            else
            {
                int count;
                majority.TryGetValue(nums[i], out count);
                majority[nums[i]] = count + 1;
            }
        }
        for (int i = 0; i < majority.Count; i++)
        {
            if (majority.ElementAt(i).Value > (nums.Length / 2))
            {
                _majority = majority.ElementAt(i).Key;
                break;
            }
        }
        return _majority;
    }
}