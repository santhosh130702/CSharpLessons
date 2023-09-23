using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DayFive
{
    internal class Task1
    {
        public static void DoTask(int x)
        {
            int l = x + 2000;
            x = l;
            Console.WriteLine(x);
        }
        public static void DoTaskA(ref int x)
        {
            int l = x + 2000;
            x = l;
            Console.WriteLine(x);
        }

    }
}
