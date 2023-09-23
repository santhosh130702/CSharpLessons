using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LessonA.DayTwo //namespace is logical grouping think it provide URI modulity application
{
    internal class DemoA
    {   //global variable
        int x = 123; //member variable/class variable/field
        static int y = 597;
        public static void FirstMethod()//static method
        {
            //local variable
            //int x = 2000;
            int y = 5000;
            //if x declared in method,it runs but x is not declared in method it can't access becasuse global variable not access in static, it also called non static member
            //Console.WriteLine(x);//local variable
            Console.WriteLine(y);//local variable
            Console.WriteLine(DemoA.y);//global static variable
        }
        int variableA = 0;
        public void SecondMethod()//non-static method
        {
            //local variable
            //int x = 2000;
            int y = 5000;
            Console.WriteLine(x);//non static member can be acccesed
            Console.WriteLine(y);//local variable
            Console.WriteLine(DemoA.y);//global static variable
        }
        public static void Summa() {
            DemoA.FirstMethod();
            //DemoB.SecondMethod();wrong not a static method

            //create an object for class demoa
            DemoA demoA_obj = new DemoA();
            //calling non static method of demoa using object reference
            demoA_obj.SecondMethod();
        }



    }
    internal class DemoB
    {

    }
}
namespace LessonA.Gavs //namespace is logical grouping think it provide URI modulity application
{
    internal class DemoA
    {
      

    }
    internal class DemoB
    {

    }
}
