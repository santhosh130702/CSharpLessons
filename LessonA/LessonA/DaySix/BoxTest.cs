using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DaySix
{
    internal class BoxTest
    {
        public static void TestA()
        {
            Box b1 = new Box();
            b1.FillList(100, 110);
            List<int> l = b1.GetList();
            foreach (int x in l)
            {
                Console.WriteLine(x);
            }
        }
        public static void TestB()
        {
            BoxA<string> b1 = new BoxA<string>();
            b1.FillList("Hello");
            List<string> l = b1.GetList();
            foreach (string s in l)
                Console.WriteLine(s);



            BoxA<float> b2 = new BoxA<float>();
            b2.FillList(55.24f);
            List<float> flist = b2.GetList();
            foreach (float f in flist)
                Console.WriteLine(f);
        }
    }
}
