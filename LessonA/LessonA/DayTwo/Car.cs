using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DayTwo
{
    internal class Car
    {
        public int CarId { get; set; }
        public string CarName { get; set; } = string.Empty;
        public string ModelName { get; set; } = string.Empty;
        public string FuelType { get; set; } = string.Empty;
        public int year  { get; set; }
        public override string ToString()
        {
            return $"CAR ID:{this.CarId}\nCAR NAME:{CarName}\nMODEL NAME:{ModelName}\n" +
            $"FUEL TYPE:{FuelType}\nyear:{year}";
        }
    }
    internal class Details
    {
        public static void TestOne()
        {
            Car firstcar = new Car();
            firstcar.CarId = 1;
            firstcar.CarName = "RR";
            firstcar.ModelName = "GHOST";
            firstcar.FuelType = "DISEL";
            firstcar.year = 2019;
            string values = firstcar.ToString();
            Console.WriteLine(values);

        }
        public static void TestTwo()
        {
            Car Secondcar = new Car();
            Secondcar.CarId = 2;
            Secondcar.CarName = "SHIFT";
            Secondcar.ModelName = "DESIGNER";
            Secondcar.FuelType = "PETROL";
            Secondcar.year = 2019;
            string values = Secondcar.ToString();
            Console.WriteLine(values);

        }


    }
}
