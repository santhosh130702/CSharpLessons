using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DayThree
{
    internal abstract class Book
    {
           public Book() {
            Console.WriteLine("book constructor");
        }
        public abstract void OpenBook();//if method is abstract,then class should be absract class
    }
}
