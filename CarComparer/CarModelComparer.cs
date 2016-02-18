using System;
using System.Collections.Generic;

namespace CarComparer
{
    public class CarModelComparer : IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            return string.Compare(x.Model, y.Model);
        }
    }
}