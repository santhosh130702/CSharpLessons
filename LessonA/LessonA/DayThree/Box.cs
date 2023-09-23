using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DayThree
{
    internal class Box
    {
        public int Height;
        public int Length;
        public int Width;

        public Box(int x)//constructor
        {
            Console.WriteLine("Box Object Created");
        }
        public void Open()
        {
            Console.WriteLine("Box is Open");
        }
        public void Close()
        {
            Console.WriteLine("Box is Closed");
        }
        public override string ToString()
        {
            return $"Height:{Height},Lenght:{Length},width:{Width}";
        }
    }
    internal class WoodenBox : Box {

        public int Area;
        public WoodenBox():base(1)//base use parameter less contractor
        {
            Console.WriteLine("Wooden Box Constructor");
        }
        public WoodenBox(int x):base(x)
        {
            Console.WriteLine("Wooden Box Constructor");
        }
        public WoodenBox(int x,int y):base(x)
        {
            Console.WriteLine("Wooden Box Constructor");
        }
        public void Move()
        {
            Console.WriteLine("wooden box shifted");
        }
        public override string ToString()
        {
            return "tom and jerry";
        }

    }
    internal class BoxTester
    {
        public static void TestTwo()
        {
            WoodenBox box = new WoodenBox();
            box.Height = 100;
            box.Length=120;
            box.Width=101;
            box.Open();
            box.Close();
            string output=box.ToString();
            Console.WriteLine(output);
            box.Area=100;
            box.Move();
        }
        public static void TestOne()
        {
            Box box = new Box(100);
            box.Height = 100;
            box.Length = 120;
            box.Width = 101;
            box.Open();
            box.Close();
            string output = box.ToString();
            Console.WriteLine(output);
            


        }
        public static void TestThree()
        {
            Box box = new WoodenBox();
            box.Height = 100;
            box.Length = 120;
            box.Width = 101;
            box.Open();
            box.Close();
            string output = box.ToString();//tom and jerry
            Console.WriteLine(output);
            // box.Area = 100;
            // box.Move();
            
        }
    }
}
