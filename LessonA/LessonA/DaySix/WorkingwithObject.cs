using LessonA.DayFive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DaySix
{
    internal class WorkingwithObject
    {
        public static void TestOne()
        {
            Object objectOne = new object();
            Console.WriteLine($"ToString: {objectOne.ToString()}");
            Console.WriteLine($"HashCode: {objectOne.GetHashCode()}");
            Type typeOne = objectOne.GetType();
            Console.WriteLine($"Type: {typeOne.FullName}");



            String stringData = "WorldCup 2023";
            Console.WriteLine($"ToString: {stringData.ToString()}");
            Console.WriteLine($"HashCode: {stringData.GetHashCode()}");//when object is loaded with key
            Type typeTwo = stringData.GetType();
            Console.WriteLine($"Type: {typeTwo.FullName}");
        }

        public static void TestTwo()
        {
            Emp empOne =new Emp();
            empOne.Id = 1001; empOne.Name = "sam";
            Emp empTwo = new Emp();
            empTwo.Id = 1001; empTwo.Name = "sam";
            Emp empThree = new Emp();
            empThree.Id = 1001;empThree.Name = "sam";
            bool flag =(empOne.Equals( empTwo) );
            Console.WriteLine(flag);
            flag=(empOne.Equals( empThree) );
            Console.WriteLine(flag);
            Console.WriteLine(empOne.GetHashCode());
            Console.WriteLine(empTwo.GetHashCode());
            Console.WriteLine(empThree.GetHashCode());


        }
        public static void TestThree()
        {
            Emp empOne = new Emp();
            empOne.Id = 1001; empOne.Name = "sam";
            Emp empTwo = empOne;
            empTwo.Id = 1001; empTwo.Name = "sam";
            Emp empThree = empOne;
            empThree.Id = 1001; empThree.Name = "sam";
            bool flag = (empOne.Equals(empTwo));
            Console.WriteLine(flag);
            flag = (empOne.Equals(empThree));
            Console.WriteLine(flag);
            Console.WriteLine(empOne.GetHashCode());
            Console.WriteLine(empTwo.GetHashCode());
            Console.WriteLine(empThree.GetHashCode());


        }
    }
}
