using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DayNine
{
    [Serializable]
     class Customer
    {
        private readonly double Id;
        public string Title;
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public double CreditLimit { get; set; }
        public Customer(double vi) { Id =vi; }
        public double GetID()
        {
            return Id;
        }
        public override string ToString()
        {
            return $"Details:{Id}{FirstName}{MiddleName}{LastName}{CreditLimit}";
        }
    }
}
