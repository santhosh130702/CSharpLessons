using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DaySeven
{
    internal class ThreadDemo
    {
        public static void DemoCurrentTH()
        {
            Thread t1 = Thread.CurrentThread;
            int id = t1.ManagedThreadId;
            Console.WriteLine("ThreadID="+id);
            Console.WriteLine("IsAlive"+t1.IsAlive);
            Console.WriteLine("priority="+t1.Priority);
            Console.WriteLine("ThreadSTAATE"+t1.ThreadState);
            Console.WriteLine("currentculture"+t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongDateString());
            t1.CurrentCulture = new CultureInfo("fr-FR");
            Console.WriteLine("currentculture"+t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongDateString());
            t1.CurrentCulture= new CultureInfo("de-DE");
            Console.WriteLine("currentculture="+ t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongDateString());

        }
        public static void DemoA()
        {
            Thread t1 = Thread.CurrentThread;
            int id = t1.ManagedThreadId;
            Console.WriteLine("Main ID" + id);
            ServiceA a1 = new ServiceA();
            a1.DoTaskA();
        }
        public static void DemoB() {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine("Main ID" + id);
            ServiceA a1 = new ServiceA();
            Thread t1 = new Thread(a1.DoTaskA);//delegate
            t1.Start();
            a1.DoTaskA();
            Console.WriteLine(".......end of demoB.......");
        }
        public static void DemoB2()
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine("Main ID" + id);
            ServiceA a1 = new ServiceA();
            Thread t1 = new Thread(a1.DoTaskA);//delegate
            Console.WriteLine(t1.ManagedThreadId + "T1. state"+ t1.ThreadState);
            t1.Start();
            Console.WriteLine(t1.ManagedThreadId + "state After starts" + t1.ThreadState);
            Thread.Sleep(3000);
            Console.WriteLine(t1.ManagedThreadId + "T1. state after sleep" + t1.ThreadState);
            Console.WriteLine(".......end of demoB.......");
        }
        public static void DemoC() { 
            Thread thread = Thread.CurrentThread;
            int id = thread.ManagedThreadId;
            Console.WriteLine("MainTh ID :"+ id);
            ServiceA a1 = new ServiceA();
            ThreadStart ts= a1.DoTaskA;
            Thread t1 = new Thread(ts);
            Thread t2 = new Thread(ts);
            t1.Start();
            t2.Start();
            Console.WriteLine(".....end  of democ.......");
        }
        public static void DemoD()
        {
            Thread thread = Thread.CurrentThread;
            int id = thread.ManagedThreadId;
            Console.WriteLine("MainTh ID :" + id);
            ServiceA a1 = new ServiceA();
            ThreadStart ts = a1.DoTaskA;
            Thread t1 = new Thread(ts);
            Thread t2 = new Thread(ts);
            t1.Start();
            t2.Start();
            t1.Join(3000);
            //if (t1.IsAlive) t1.Abort();
            t2.Join(3000);
            //if (t2.IsAlive) t2.Abort();
            Console.WriteLine(".....end  of democ.......");
        }
    }
    
}
