using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// link to the problem: https://leetcode.com/problems/shuffle-string/

/* Description:
 * 
 * You are given a string s and an integer array indices of the same length.
 * The string s will be shuffled such that the character at the ith position moves to indices[i] 
 * in the shuffled string.
 * Return the shuffled string.
 */

public class Exercise8
{
    public string RestoreString(string s, int[] indices)
    {
        string shuffled = "";
        for (int i = 0; i < s.Length; i++)
        {
            shuffled += s[Array.IndexOf(indices, i)].ToString();
        }
        return shuffled;
    }
}

/* TestCase: 
 * 
 *  Input: s = "codeleet", indices = [4,5,6,7,0,2,1,3]
    Output: "leetcode"
    Explanation: As shown, "codeleet" becomes "leetcode" after shuffling.
 */