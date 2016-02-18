using System;

namespace CarComparer
{
    public class Car : IComparable<Car>
    {
        public string RegNo;
        public string Model;
        public int Year;

        public int CompareTo(Car obj)
        {
            Car c = (Car)obj;
            return string.CompareOrdinal(this.RegNo, c.RegNo);
        }
    }

}