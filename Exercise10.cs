using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
