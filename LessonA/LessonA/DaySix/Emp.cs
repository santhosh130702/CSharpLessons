using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DaySix;

class Emp1
{
    public int Eno = 0;
    private readonly Address address;
    public Emp1()
    {
        address = new Address(this);
    }
    public Address GetAddress()
    {
        return address;
    }

    public class Address
    {
        public string Address1;
        public string Address2;
        private readonly Emp1 e1;
        internal Address(Emp1 outerEmp)
        {
            if (outerEmp == null) 
                throw new NullReferenceException("outer emp is null");
            e1 = outerEmp;
        }
        public override string ToString()
        {
            return Address1 + "." + Address2 + "." + e1.Eno;
        }
    }

}
