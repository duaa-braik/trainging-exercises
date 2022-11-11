using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// link to the problem: https://leetcode.com/problems/contains-duplicate/

/*
 * Given an integer array nums, return true if any value appears at least twice in 
 * the array, and return false if every element is distinct.
 */

public class Exercise2
{
    public bool ContainsDuplicate(int[] nums)
    {
        Dictionary<int, int> duplicates = new Dictionary<int, int>();
        bool hasDuplicates = false;
        for (int i = 0; i < nums.Length; i++)
        {
            if (!duplicates.ContainsKey(nums[i]))
            {
                duplicates.Add(nums[i], 1);
            }
            else
            {
                hasDuplicates = true;
            }

        }
        return hasDuplicates;
    }
}