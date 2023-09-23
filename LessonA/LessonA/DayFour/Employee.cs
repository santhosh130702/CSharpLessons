using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DayFour
{   
    public enum City { chennai,banglore,hyderabad}
    public enum Designation { manager,admin,developer}
    class Employee
    {
        public readonly int Eid;
        public string Ename= String.Empty;
        public City Ecity;
        public Designation JobTitle;
        public Employee(int v1) { Eid = v1; }
        public override string ToString()
        {   
            String output= String.Empty;
            output = $"Details of a employee are : ID={Eid} Name={Ename} {Ecity} {JobTitle}";
            return output;
        }

    }
    class TestEmployee
    {
        public static void TestOne() { 
            Employee e1 = new Employee(348);
            e1.Ename = "john";
            e1.Ecity=City.chennai;
            e1.JobTitle = Designation.developer;
            String output= e1.ToString();
            Console.WriteLine(output);
        } 
    }
    class TestEnum
    {

        public static void TestMovieRating()
        {
            Type t1 = typeof(MovieRating);
            String[] enumNames = Enum.GetNames(t1);
            String name = String.Empty;
            int len = enumNames.Length;
            for (int i = 0; i < len; i++)
            {
                name = enumNames[i];
                MovieRating movies = (MovieRating)Enum.Parse(t1, name);
                Console.WriteLine(name + " " + (int)movies);
            }
        }

    }


}
