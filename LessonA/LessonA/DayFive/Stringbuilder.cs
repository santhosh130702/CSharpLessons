using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DayFive
{
    internal class Stringbuilder
    {


        // Main Method
        public static void Hello()
        {

            // "20" is capacity
            StringBuilder s = new StringBuilder("HELLO ", 20);

            s.AppendLine("GFG");
            Console.WriteLine(s);
            s.AppendLine("GEEKS");
            Console.WriteLine(s);

            //s.AppendFormat("{0:C} ", 50);
            //Console.WriteLine(s);

            // "GEEKS" insert after 6th index
            s.Insert(6, "GEEKS");

            Console.WriteLine(s);

            s.Remove(5, 3);

            Console.WriteLine(s);

            s.Replace("GFG", "Geeks For");

            Console.WriteLine(s);
        }
    }
}
