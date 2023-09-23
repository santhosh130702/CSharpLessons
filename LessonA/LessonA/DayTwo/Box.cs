using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DayTwo
{
    internal class Box
    {
        public static int height;
        public int width;
        public const string type = "wooden";

        public int GetHeight(){return height;}
    }
    internal class TestBox
    {
        public static void TestOne()
        {
            Box.height = 100;
            //Box.width = 200;
            Box firstbox =new Box();
            Box secondbox =new Box();   
            firstbox.width = 11234;
            secondbox.width = 98765;
            Console.WriteLine($"FIRSTBOX={firstbox.width},{firstbox.GetHeight()}");
            Console.WriteLine($"SECONDBOX={secondbox.width},{secondbox.GetHeight()}");
            Box.height = 5000;
            Console.WriteLine($"FIRSTBOX={firstbox.width},{firstbox.GetHeight()}");
            Console.WriteLine($"SECONDBOX={secondbox.width},{secondbox.GetHeight()}");
            Console.WriteLine(Box.type);

        }

    }
}
