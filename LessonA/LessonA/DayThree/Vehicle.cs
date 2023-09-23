using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DayThree
{
    internal abstract class Vehicle//it not compulsory abstract class
    {
        public Vehicle() {
            Console.WriteLine("vehicle constructor");
        }
        public void Start()
        {
            Console.WriteLine("vehicle started");   
        }
    }
    //end of class
    internal class Car:Vehicle { 
        public Car()
        {
            Console.WriteLine("car constructor");
        }
    }
    class VehicleTester
    {
        public static void TestOne()//abstract class must be inherited
        {
            //Vehicle tester = new Vehicle() 
            Vehicle tester = new Car();
            tester.Start();
        }
    }
}
