using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// link to the problem: https://leetcode.com/problems/length-of-last-word/

/*
 * Given a string s consisting of words and spaces, return the length of the last word in the string.
   A word is a maximal substring consisting of non-space characters only.
 */

public class Exercise3
{
    public int LengthOfLastWord(string s)
    {
        string[] words = s.Split(' ');
        string lastWord = "";
        for (int i = words.Length - 1; i >= 0; i--)
        {
            if (words[i].Length > 0)
            {
                lastWord = words[i];
                break;
            }
        }

        return lastWord.Length;
    }
}
