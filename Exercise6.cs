using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// link to the problem : https://leetcode.com/problems/rotate-string/

/* Description: 
 * Given two strings s and goal, return true if and only if s can become goal after some
 * number of shifts on s.
 * A shift on s consists of moving the leftmost character of s to the rightmost position.
 * For example, if s = "abcde", then it will be "bcdea" after one shift.
 */

public class Exercise6
{
    public bool RotateString(string s, string goal)
    {
        string leftMost = "";
        int length = s.Length;
        bool equals = false;
        for (int i = 0; i < length; i++)
        {
            leftMost = s[0].ToString();
            s = s.Remove(0, 1);
            s += leftMost;
            if (s == goal)
            {
                equals = true;
                break;
            }
        }
        return equals;
    }
}
