using System;
using System.Collections.Generic;

namespace CarComparer
{
    public class CarYearComparer : IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            {
                if (x.Year < y.Year)
                {
                    return -1;
                }
                if (x.Year == y.Year)
                {
                    return 0;
                }
                return 1;
            }
        }
    }
}