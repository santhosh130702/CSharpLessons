//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
namespace LessonA.DaySeven
{
    class ServiceA
    {
        int x = 0;
        public void DoTaskA()
        {
            Monitor.Enter(this);
            Thread t1 = Thread.CurrentThread;
            int id = t1.ManagedThreadId;
            Console.WriteLine("inside DoTaskA");
            Console.WriteLine("\t Thread ID :" + id);
            //int x = 0;
            try
            {
                for (int icount = 0; icount < 10; icount++)
                {
                    x += icount;
                    Console.WriteLine("\t ID= " + id + ": x=" + x + "icount " + icount);
                    Thread.Sleep(1000);
                }
            }
            finally
            {
                Monitor.Exit(this);
            }
        }
}
}
