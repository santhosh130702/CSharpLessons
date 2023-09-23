using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DaySix
{
    internal class TestHGenericcs <T>
    {
        public  void Add(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1+d2);
        }
    }
    class TestMethod
    {
        public static void Implementation()

        {
            TestHGenericcs <string> obj = new TestHGenericcs <string>();
            obj.Add("hello", "hi");




        }
    }
}
