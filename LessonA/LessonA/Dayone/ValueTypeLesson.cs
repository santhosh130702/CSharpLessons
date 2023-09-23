using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Dayone
{
    internal class ValueTypeLesson
    {
        public static void TestValueTypes()
        {
           
            char c1 = 'a';
            Console.WriteLine(c1);
            int x = c1;
            Console.WriteLine(x);
            bool flag = true;
            Console.WriteLine(flag);
            
        }
        public static void TestMethod()//HEADER
        {
            Console.WriteLine("TEST");//METHOD BODY 
        }

    }
}
