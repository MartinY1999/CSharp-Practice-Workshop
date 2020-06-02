using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifier
{
    public class DateModifier
    {
        public static long ReturnTimeBetween(string startDate, string endDate)
        {
            string[] start = startDate.Split(' ');
            string[] end = endDate.Split();
            DateTime newS = new DateTime(int.Parse(start[0]), int.Parse(start[1]), int.Parse(start[2]));
            DateTime newE = new DateTime(int.Parse(end[0]), int.Parse(end[1]), int.Parse(end[2]));
            TimeSpan difference = newE - newS;
            return Math.Abs(difference.Days);
        }
    }
}
