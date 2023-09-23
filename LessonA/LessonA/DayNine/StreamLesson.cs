using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LessonA.DayNine
{
    internal class StreamLesson
    {
        public static void TestOne()
        {
            char ch;
            Console.WriteLine("press a key followed by enter");
            int x = Console.Read();
            ch =(char)x;
            Console.WriteLine("\n"+x+"your key is :"+ch);
        } 
        public static void TestTwo() 
        {   
            char ch= ' ';
            Console.WriteLine("press a key Q to exit");
            while(ch !='q')
            {
                ch = (char)Console.Read();
                Console.WriteLine("your key is :"+ch);
            }
   
         }
        public static void TestThree()
        {
            Console.Out.WriteLine("enter  as sentences");
            string? str =Console.ReadLine();
            Console.Out.WriteLine(""+str);
         }
        public static void TestNullable()
        {
            int? x = 10;
            x = null;
            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
                Console.WriteLine(x.GetValueOrDefault());
        }
    }
}
