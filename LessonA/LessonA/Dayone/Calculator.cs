using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Dayone
{
    internal class Calculator
    {
        public static int Add(int p1,int p2)
        {
            return p1+p2;
        }
        public static int Subtract(int p1, int p2)
        {
            return p1-p2;
        }
        public static int Divide(int p1, int p2)
        {
            return p1/p2;
        }
        public static int Multiply(int p1, int p2)
        {
            return p1*p2;
        }
        public static void TestCalculator()
        {
            Console.WriteLine("ENTER THE 1st NUMBER");
            string x = Console.ReadLine();
            Console.WriteLine("ENTER THE 2nd NUMBER");
            string y = Console.ReadLine();
            int firstvalue = int.Parse(x);
            int secondvalue = int.Parse(y);
            int addresult = Calculator.Add(firstvalue, secondvalue);
            Console.WriteLine("add=" + addresult);
            int multiplyresult = Calculator.Multiply(firstvalue, secondvalue);
            Console.WriteLine("multiply=" + multiplyresult);
            int divideresult = Calculator.Divide(firstvalue, secondvalue);
            Console.WriteLine("divide=" + divideresult);
            int subtractionres = Calculator.Subtract(firstvalue, secondvalue);
            Console.WriteLine("subtract=" + subtractionres);
        }
    }
}
