using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DayTwo
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }= string.Empty;
        public string FirstName { get; set; } = string.Empty;   
        public string LastName { get; set; } = string.Empty;
        public string Title { get; set; }= string.Empty;
        public string Address { get; set; } = string.Empty; 
        public string City { get; set; } = string.Empty;
        public string Region { get; set; }  =string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;     
        public long Phone { get; set; }
        public override string ToString()
        {
            return $"ID:{this.Id},name:{Title} {FirstName}{LastName},"+
                $"address:{Address},phone:{Phone},country:{Country}"+
                $"city:{City},zip:{PostalCode},region:{Region}";
        }
    }
    internal class TestPerson 
    {
        public static void TestOne()
        {
            Person firstperson = new Person();
            firstperson.Id = 1;
            firstperson.FirstName = "santhosh";
            firstperson.LastName = "S";
            firstperson.Title = "Mr.";
            firstperson.Address = "Medavakkam";
            firstperson.City = "chennai";
            firstperson.Phone = 9025681637;
            firstperson.PostalCode = "6001000";
            firstperson.Region = "Tamilan";
            firstperson.Country = "india";
            string values = firstperson.ToString();
            Console.WriteLine(values);

        }
    }
}
