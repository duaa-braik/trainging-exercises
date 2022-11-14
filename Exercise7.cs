using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// link to the problem : https://leetcode.com/problems/reverse-words-in-a-string/

/* Description: 
 * 
 * Given an input string s, reverse the order of the words.
 * A word is defined as a sequence of non-space characters. 
 * The words in s will be separated by at least one space.
 * Return a string of the words in reverse order concatenated by a single space.
 * Note that s may contain leading or trailing spaces or multiple spaces between two words. The returned string should only have a single space separating the words. Do not include any extra spaces.
 */

namespace Stack
{
    using System.Collections.Generic;
    public class Exercise7
    {
        public string ReverseWords(string s)
        {
            s = s.Trim();
            string[] words = s.Split(' ');
            Stack<string> stack = new Stack<string>();
            Console.WriteLine(words.Length);
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i].Length);
                if (words[i].Length > 0)
                    stack.Push(words[i]);
            }
            s = "";
            while (stack.Count > 0)
            {
                s += stack.Pop();
                if (stack.Count > 0)
                    s += " ";
            }
            return s;
        }
    }
}
