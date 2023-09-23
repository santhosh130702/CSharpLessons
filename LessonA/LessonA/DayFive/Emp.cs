using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DayFive
{
    internal class Emp
    {

            public  int  Id;
            public string Name;
            public string FirstName { get; set; }
            public string MiddleName { get; set; }
            public string LastName { get; set; }
            public double Salary { get; set; }
            public Emp() { }
            public Emp(int v1)
            {
                Id = v1;
            }
            public double GetID()
            {
                return Id;
            }
        
    }
}
