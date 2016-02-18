using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarComparer
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Car> cars = new List<Car>()
            {
                new Car() {Model = "BMW", RegNo = "AA 00 022", Year = 2008},
                new Car() {Model = "Volvo", RegNo = "CC 00 011", Year = 2010},
                new Car() {Model = "Audi", RegNo = "BB 00 033", Year = 2007},
                new Car() {Model = "Opel", RegNo = "DD 00 044", Year = 2007},
                new Car() {Model = "Mercedes", RegNo = "EE 00 066", Year = 1997},
                new Car() {Model = "BMW", RegNo = "AA 00 055", Year = 2006},
            };

            Console.WriteLine("Without any sorting:");
            PrintToConsole(cars);

            Console.WriteLine("");
            Console.WriteLine("Sorted by registration number:");
            cars.Sort();
            PrintToConsole(cars);

            Console.WriteLine("");
            Console.WriteLine("Sorted by year:");
            CarYearComparer yearComparer = new CarYearComparer();
            cars.Sort(yearComparer);
            PrintToConsole(cars);

            Console.WriteLine("");
            Console.WriteLine("Sorted by model:");
            CarModelComparer modelComparer = new CarModelComparer();
            cars.Sort(modelComparer);
            PrintToConsole(cars);




            Console.ReadKey();
        }

        public static void PrintToConsole(List<Car> cars)
        {
            foreach (var car in cars)
            {
                Console.WriteLine(car.Model.ToString() + " " + car.RegNo.ToString() + " " + car.Year.ToString());
            }
        }
    }
}
