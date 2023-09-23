using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DayFive
{
    internal class Collectionone
    {
        public static void TestArrayList()
        {
            ArrayList alist = new ArrayList();
            int count = alist.Count;
            Console.Write("Count " + count);
            Console.WriteLine(" Capacity " + alist.Capacity);// 0
            Random r1 = new Random();
            for (int i = 0; i < 10; i++)
                alist.Add(r1.Next(10));
            Console.Write("Count " + alist.Count);
            Console.WriteLine(" Capacity " + alist.Capacity);// 16
        }
        public static void TestArrayList2()
        {
            ArrayList alist = new ArrayList();
            int count = alist.Count;
            Console.Write("Count " + count);
            Console.WriteLine(" Capacity " + alist.Capacity);// 0
            Random r1 = new Random();
            for (int i = 0; i < 10; i++)
                alist.Add(r1.Next(10));
            Console.Write("Count " + alist.Count);
            Console.WriteLine(" Capacity " + alist.Capacity);// 16
            for (int j = 0; j < 10; j++) alist.Add(j);
            Console.Write("Count " + alist.Count);
            Console.WriteLine(" Capacity " + alist.Capacity);// 32



            for (int i = 0; i < alist.Count; i++)
            {
                Console.Write(alist[i] + ",");
                if (i > 0 && i % 10 == 0) Console.WriteLine();
            }
        }
        public static void TestArrayList3()
        {
            ArrayList alist = new ArrayList();
            int count = alist.Count;
            Console.Write("Count " + count);
            Console.WriteLine(" Capacity " + alist.Capacity);// 0
            Random r1 = new Random();
            for (int i = 0; i < 10; i++)
                alist.Add(r1.Next(10));
            Console.Write("Count " + alist.Count);
            Console.WriteLine(" Capacity " + alist.Capacity);// 16
                                                             //IEnumerable
            foreach (int x in alist)
            {
                Console.Write(x + " ");
            }
        }
        public static void TestArrayList4()
        {
            ArrayList alist = new ArrayList();
            int count = alist.Count;
            Console.Write("Count " + count);
            Console.WriteLine(" Capacity " + alist.Capacity);// 0
            Random r1 = new Random();
            for (int i = 0; i < 10; i++)
                alist.Add(r1.Next(10));
            Console.Write("Count " + alist.Count);
            Console.WriteLine(" Capacity " + alist.Capacity);// 16
            if (alist is IEnumerable)//does alist impliment IEnumerable
            {
                IEnumerator er = alist.GetEnumerator();
                while (er.MoveNext())
                {
                    object obj = er.Current;
                    if (typeof(int) == obj.GetType())
                    {
                        int x = (int)obj;// unboxing
                        Console.WriteLine(x);
                    }
                    else
                        Console.WriteLine(obj.ToString());
                }
            }
        }
        public static void GenericListInteger()
        {
            List<int> alist = new List<int>();
            int count = alist.Count;
            Console.Write("Count " + count);
            Console.WriteLine(" Capacity " + alist.Capacity);



            for (int i = 0; i < 10; i++)
                alist.Add(i);
            Console.Write("Count " + alist.Count);
            Console.WriteLine(" Capacity " + alist.Capacity);



            //for (int j = 0; j < 10; j++)
            //    alist.Add("abcd" + j);





            for (int i = 0; i < count; i++)
            {
                Console.Write(alist[i] + ",");
            }
        }

        public static void GenericListString()
        {
            List<string> alist = new List<string>();
            int count = alist.Count;
            Console.Write("Count " + count);
            Console.WriteLine(" Capacity " + alist.Capacity);
            for (int j = 0; j < 10; j++)
                alist.Add("abcd" + j);
            Console.Write("Count " + alist.Count);
            Console.WriteLine(" Capacity " + alist.Capacity);
            //for (int i = 0; i < 10; i++)
            //    alist.Add(i);
            for (int i = 0; i < count; i++)
            {
                Console.Write(alist[i] + ",");
            }
        }

        public static void GenericListDemoEmp()
        {
            List<Emp> empList = new List<Emp>();



            Console.Write("Length " + empList.Count);
            Console.WriteLine("\tCapacity " + empList.Capacity);
            Emp e1 = new Emp() { Id = 123, Name = "Venkat", Salary = 10000 };
            empList.Add(e1);
            empList.Add(new Emp() { Id = 456, Name = "Krishnan", Salary = 15000 });
            //empList.Add("Hello");
            Console.Write("Length " + empList.Count);
            Console.WriteLine("\tCapacity " + empList.Capacity);
            empList.Add(new Emp() { Id = 1000, Name = "Sam", Salary = 10000 });
            empList.Add(new Emp() { Id = 500, Name = "John", Salary = 10000 });
            empList.Add(new Emp() { Id = 200, Name = "Suresh", Salary = 10000 });
            empList.Add(e1);
            empList.Add(e1);



            Console.Write("Length " + empList.Count);
            Console.WriteLine("\tCapacity " + empList.Capacity);
            //IEnumerator data = empList.GetEnumerator();
            //while (data.MoveNext())
            //{
            //    Object obj = data.Current;
            //    if (obj.GetType() == typeof(Emp))
            //    {
            //        Emp e = (Emp)obj;
            //        Console.WriteLine("Id={0}, Name={1}, Salary={2} ", e.ID, e.Name, e.Salary);
            //    }
            //    else
            //        Console.WriteLine("=======> Object is not an Employee");
            //}
            foreach (Emp e2 in empList)
            {
                Console.WriteLine("Id={0}, Name={1}, Salary={2} ", e2.Id, e2.Name, e2.Salary);
            }
        }
        public static void Anagram()
            {

                String str = "He was at the 24 floor of the building. He saw 42 pots of flowers there. He stop to check if the pots are watered.";

                str = str.Replace(".", "");

                char[] temp1, temp2;

                String str1, str2;

                String[] far = str.Split(" ");

                for (int i = 0; i < far.Count(); i++)
                {
                    temp1 = far[i].ToCharArray();

                    Array.Sort(temp1);

                    str1 = new String(temp1);

                    for (int j = 0; j < far.Count(); j++)
                    {

                        temp2 = far[j].ToCharArray();

                        Array.Sort(temp2);

                        str2 = new String(temp2);

                        if (far[i].Length == far[j].Length)
                        {

                            if (str1.Equals(str2) && !far[i].Equals(far[j]))

                            {

                                System.Console.WriteLine(far[i] + " " + far[j]);

                            }

                        }

                    }

                }

            }

        public static void SetStringDemo()
        {
            HashSet<String> stringSet = new HashSet<String>();
            stringSet.Add("Chennai");
            stringSet.Add("Salem");
            stringSet.Add("Erode");
            stringSet.Add("Tirupur");
            stringSet.Add("Kovai");
            stringSet.Add("Chennai");
            stringSet.Add("Trichy");
            stringSet.Add("Madurai");
            stringSet.Add("Nellai");
            stringSet.Add("Trichy");
            stringSet.Add("Trichy");
            stringSet.Add("Trichy");
            stringSet.Add(null);
            stringSet.Add(null);
            Console.WriteLine($"Count:{stringSet.Count}");
            foreach (var item in stringSet)
            {
                if (item != null)
                    Console.WriteLine(item);
                else
                    Console.WriteLine("NULL");
            }



        }
        public static void TestGenericSortedSetInt()
        {
            SortedSet<int> alist = new SortedSet<int>();
            int count = alist.Count;
            Console.WriteLine("Count " + count);
            alist.Add(10);
            alist.Add(10);
            alist.Add(10);
            Random r1 = new Random();
            for (int i = 0; i < 10; i++)
            {
                int x = r1.Next(100);
                alist.Add(x);
                Console.Write(x + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Count " + alist.Count);
            foreach (int i in alist)
                Console.Write(i + ",");
        }
        public static void TestGenericSortedSetString()
        {
            SortedSet<string> alist = new SortedSet<string>();
            int count = alist.Count;
            Console.WriteLine("Count " + count);
            alist.Add("Hello");
            alist.Add("Hello");
            alist.Add("Hello");
            alist.Add("Ashley");
            alist.Add("Gavs");
            alist.Add("Gavs");
            alist.Add("Infy");
            alist.Add("CTS");
            alist.Add("TCS");
            alist.Add("Adyar");
            alist.Add("Banglore");
            alist.Add("Pune");
            alist.Add("Goa");
            alist.Add("Zif");



            Console.WriteLine();
            Console.WriteLine("Count " + alist.Count);
            foreach (string i in alist) Console.Write(i + ",");



        }

        public static void TestQueue()
        {
            Queue q = new Queue();
            Random r = new Random();
            int x = 0;
            q.Enqueue(25);
            Console.Write(25 + " ");
            for (int i = 0; i < 10; i++)
            {
                x = r.Next(100);
                q.Enqueue(x);
            }
            Console.WriteLine("");
            int count = q.Count;
            Console.WriteLine("Count=" + count);
            for (int i = 0; i < count; i++)
            {
                Console.Write(q.Peek() + " ");
                // Peek reads the first object in the queue 
                // without removing the object
            }
            Console.WriteLine("");
            count = q.Count;
            Console.WriteLine("Count After Peek =" + count);
            Console.WriteLine("Contains 25-" + q.Contains(25));
            for (int i = 0; i < 5; i++)
            {
                Console.Write(q.Dequeue() + " ");
            }
            Console.WriteLine("");
            count = q.Count;
            Console.WriteLine("Count After Dequeue=" + count);
        }
        public static void StackDemoA()
        {
            Stack st = new Stack();
            Random r = new Random();
            int x = 0;
            st.Push(25);
            for (int i = 0; i < 10; i++)
            {
                x = r.Next(100);
                st.Push(x);
            }
            Console.WriteLine("");
            int count = st.Count;
            Console.WriteLine("Count=" + count);
            for (int i = 0; i < count; i++)
            {
                Console.Write(st.Peek() + " ");
                // Peek reads the first object in the queue 
                // without removing the object
            }



            Console.WriteLine("");
            count = st.Count;
            Console.WriteLine("Count After Peek =" + count);
            Console.WriteLine("Contains 25-" + st.Contains(25));
            for (int i = 0; i < 5; i++)
            {
                Console.Write(st.Pop() + " ");
            }
            Console.WriteLine();
            count = st.Count;
            Console.WriteLine("Count After Pop=" + count);
        }
        public static void HashtableDemo()
        {
            Hashtable ht = new Hashtable();
            Console.WriteLine("Count " + ht.Count);
            Console.WriteLine("IsFixedSize " + ht.IsFixedSize);
            ht.Add("id", 123);
            ht.Add("name", "Gates");
            Console.WriteLine("Count " + ht.Count);
            ht.Add("sal", 15000);
            ht.Add("r1", new Random().Next());
            ht.Add("IsDirector", false);
            ht.Add("Address", null);
            //ht.Add("name", "Bill");// Runtime Error duplicate key 
            Console.WriteLine("Count " + ht.Count);
            Console.WriteLine(ht["sal"]);
            Console.WriteLine("ContainsKey(r1) " + ht.ContainsKey("r1"));
            Console.WriteLine("ContainsKey(name) " + ht.ContainsKey("name"));
            foreach (object k in ht.Keys)
                Console.WriteLine(k + "--" + ht[k]);
        }
        public static void EmpHTDemo()
        {
            Hashtable empTable = new Hashtable();
            for (int i = 1; i <= 10; i++)
            {
                Emp e = new Emp()
                {
                    Id = i,
                    Name = "Emp" + i,
                    Salary = 10000 * i
                };
                empTable.Add(e.Id, e);
            }
            Console.WriteLine("Count " + empTable.Count);
            Console.WriteLine("ContainsKey(5) " + empTable.ContainsKey(5));
            Console.WriteLine("ContainsKey(15) " + empTable.ContainsKey(15));
        }   
        public static void EmpDictionaryDemo()

        {

            Dictionary<int, Emp> empMap = new Dictionary<int, Emp>();

            for (int i = 1; i <= 10; i++)

            {

                Emp e = new Emp()

                {

                    Id = i,

                    Name = "Emp" + i,

                    Salary = 10000 * i

                };

                empMap.Add(e.Id, e);

            }

            Emp e1 = new Emp() { Id = 12345, Name = "Venkat", Salary = 1000000 };

            empMap.Add(15, e1);

            empMap.Add(16, e1);



            Console.WriteLine("Count " + empMap.Count);

            Console.WriteLine("ContainsKey(5) " + empMap.ContainsKey(5));

            Console.WriteLine("ContainsKey(15) " + empMap.ContainsKey(15));

        }

        public static void TestSortedListA()
        {
            SortedList<int, int> slist = new SortedList<int, int>();
            int count = slist.Count;
            Console.WriteLine("Count " + count);
            Console.WriteLine(" Capacity " + slist.Capacity);
            Random r1 = new Random();
            for (int i = 0; i < 10; i++)
            {
                int x = r1.Next(100);
                if (!slist.ContainsKey(x))
                    slist.Add(x, i* 55);
                Console.Write(x + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Count " + slist.Count);
            Console.WriteLine(" Capacity " + slist.Capacity);



            foreach (var i in slist)
            {
                Console.WriteLine(i.Key + "," + i.Value);
            }
        }
        public static void TestSortedListOfEmp()
        {
            SortedList<int, Emp> empsortlist = new SortedList<int, Emp>();
            Random r1 = new Random();
            Emp e1 = new Emp() { Id = r1.Next(100), Name = "John", Salary = r1.NextDouble() * 5000 };
            Emp e2 = new Emp() { Id = r1.Next(100), Name = "Sam", Salary = r1.NextDouble() * 5000 };
            Emp e3 = new Emp() { Id = r1.Next(100), Name = "Ajith", Salary = r1.NextDouble() * 5000 };
            Emp e4 = new Emp() { Id = r1.Next(100), Name = "Ellango", Salary = r1.NextDouble() * 5000 };
            Emp e5 = new Emp() { Id = r1.Next(100), Name = "Basker", Salary = r1.NextDouble() * 5000 };
            if (!empsortlist.ContainsKey(e1.Id))
                empsortlist.Add(e1.Id, e1);
            if (!empsortlist.ContainsKey(e2.Id))
                empsortlist.Add(e2.Id, e2);
            if (!empsortlist.ContainsKey(e3.Id))
                empsortlist.Add(e3.Id, e3);
            if (!empsortlist.ContainsKey(e4.Id))
                empsortlist.Add(e4.Id, e4);
            if (!empsortlist.ContainsKey(e5.Id))
                empsortlist.Add(e5.Id                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       , e5);



            Console.WriteLine("Count " + empsortlist.Count);
            Console.WriteLine(" Capacity " + empsortlist.Capacity);



            foreach (var emp in empsortlist)
            {
                Console.WriteLine(emp.Key + " : " + emp.Value.Name);
            }
            Console.WriteLine("===================");

            var orderedlist = empsortlist.OrderBy(tkey => tkey.Value.Name);
            foreach (var emp in orderedlist)
            {
                Console.WriteLine(emp.Key + " : " + emp.Value.Name);
            }
            Console.WriteLine("===================");
            var desclist = empsortlist.OrderByDescending(tkey => tkey.Value.Name);
            foreach (var emp in desclist)
            {
                Console.WriteLine(emp.Key + " : " + emp.Value.Name);
            }
        }
    }
   
}
