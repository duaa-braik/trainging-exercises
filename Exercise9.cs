using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// a link to the problem: https://leetcode.com/problems/day-of-the-year/

/* Description: 
 * Given a string date representing a Gregorian calendar date 
 * formatted as YYYY-MM-DD, return the day number of the year.
 */


public class Exercise9
    {
        public int DayOfYear(string date)
        {
            string[] YMD = date.Split("-");
            int days = 0;
            int[] months = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int year = Int32.Parse(YMD[0]);
            int month = Int32.Parse(YMD[1]);
            int day = Int32.Parse(YMD[2]);
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        months[1] = 29;
                    }
                }
                else months[1] = 29;
            }
            // m = 5, i = 4
            for (int i = 1; i < month; i++)
            {
                days += months[i - 1];
            }
            days += day;

            return days;
        }
    }

