using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// link to the problem: https://leetcode.com/problems/baseball-game/

/* Description:
 * 
 * You are keeping the scores for a baseball game with strange rules. 
 * At the beginning of the game, you start with an empty record.

   You are given a list of strings operations, where operations[i] is the ith operation 
   you must apply to the record and is one of the following:

    An integer x.
        Record a new score of x.
    '+'.
    Record a new score that is the sum of the previous two scores.
    'D'.
    Record a new score that is the double of the previous score.
    'C'.
    Invalidate the previous score, removing it from the record.
    Return the sum of all the scores on the record after applying all the operations.

    The test cases are generated such that the answer and all intermediate calculations 
    fit in a 32-bit integer and that all operations are valid.
 */

public class Solution
{
    public int CalPoints(string[] operations)
    {
        int sum = 0;
        List<int> scores = new List<int>();
        int scores_length = scores.Count;
        for (int i = 0; i < operations.Length; i++)
        {
            scores_length = scores.Count;
            switch (operations[i])
            {
                case "+":
                    int first = scores[scores_length - 1];
                    int second = scores[scores_length - 2];
                    if (scores_length >= 2)
                    {
                        scores.Add(first + second);
                        sum += (first + second);
                    }
                    break;
                case "D":
                    int _Double = scores[scores_length - 1];
                    if (scores_length >= 1)
                    {
                        scores.Add(2 * _Double);
                        sum += (2 * _Double);
                    }
                    break;
                case "C":
                    sum -= scores[scores_length - 1];
                    scores.RemoveAt(scores_length - 1);

                    break;
                default:
                    int new_score = int.Parse(operations[i]);
                    scores.Add(new_score);
                    sum += new_score;
                    break;
            }
        }
        return sum;
    }
}