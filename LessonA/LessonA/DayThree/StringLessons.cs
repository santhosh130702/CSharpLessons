﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DayThree
{
    internal class StringLessons
    {   public static void DemoA()
        {
            String firststring = "hello";
            char[] data = { 'h', 'e', 'l', 'l', 'o' };
            String secondstring = new String(data);
            Console.WriteLine(firststring+""+secondstring);
            String thridString = String.Empty;
            int x = 0;
        }
        public static void DemoB()
        {
            String s1 = "Tom and jerry";
            Console.WriteLine("Length"+ s1.Length);
            char[] data = s1.ToCharArray();
            foreach (char c1 in data)
            {
                Console.WriteLine(c1);
                
            }
        }
        public static void DemoC()
        {
            String s1 = "Tom and jerry";
            Console.WriteLine("Length" + s1.Length);
            String[] words = s1.Split();
            Console.WriteLine("WORD COUNT"+ words.Count());
            foreach (var item in words)
            {
                Console.WriteLine(item);

            }
        }
        public static void DemoD()
        {
            String firststring = "Tom and jerry";
            String stringINUPPER=firststring.ToUpper();
            Console.WriteLine(stringINUPPER);
            Console.WriteLine(firststring);
            String stringINLOWER = firststring.ToLower();
            Console.WriteLine(stringINLOWER);
            Console.WriteLine(firststring);
        }
        public static void DemoE()
        {
            String secondString = "    abcdef    ";
            String trimmedString = secondString.Trim();
            Console.WriteLine(secondString);
            Console.WriteLine("secondString Length: " + secondString.Length);
            Console.WriteLine(trimmedString);
            Console.WriteLine("trimmedString Length: " + trimmedString.Length);
            String trimmedAtEnd = secondString.TrimEnd();
            Console.WriteLine(trimmedAtEnd);
            Console.WriteLine("trimmedAtEnd Length: " + trimmedAtEnd.Length);
            String trimmedAtStart = secondString.TrimStart();
            Console.WriteLine(trimmedAtStart);
            Console.WriteLine("trimmedAtStart Length: " + trimmedAtStart.Length);
        }
        public static void TestStringEquals()
        {
            String firstString = "Hello";
            String secondString = "Hello";
            String thirdString = "Gavs";



            bool firstResult = (firstString == secondString);
            bool secondResult = (firstString == thirdString);
            Console.WriteLine("firstString==secondString " + firstResult); // true
            Console.WriteLine("firstString==thirdString " + secondResult);// true
            firstResult = (firstString.Equals(secondString));
            secondResult = (firstString.Equals(thirdString));
            Console.WriteLine("firstString.Equals(secondString) " + firstResult); // true
            Console.WriteLine("firstString.Equals(thirdString) " + secondResult); // true
            String fourthstring = new String(new char[] { 'h', 'e', 'l', 'l', 'o' });
            firstResult = (firstString.Equals(fourthstring));
            Console.WriteLine("firstString.Equals(fourthstring)"+firstResult);
            firstResult = (firstString.Equals(fourthstring));
            Console.WriteLine("firstString.Equals(fourthstring)" + firstResult);

        }
        public static void TestSubstring()
        {
            String s1 = "It looks like September is going to have more rain";
            Console.WriteLine(s1);
            Console.WriteLine("Length " + s1.Length);
            String s2 = s1.Substring(5);
            Console.WriteLine(s2);
            Console.WriteLine("s2 Length " + s2.Length);
            //from 5th index next 10 char
            String s3 = s1.Substring(5, 10);
            Console.WriteLine(s3);
            Console.WriteLine("s3 Length " + s3.Length);
        }
        public static void TestCompareTo()
        {
            String s1 = "September";
            String s3 = "November";
            int x = s1.CompareTo(s3);
            Console.WriteLine("September Compare November = " + x);
            x = s1.CompareTo("Saptember");
            Console.WriteLine("September Compare Saptember = " + x);
            x = s1.CompareTo("September");
            Console.WriteLine("September Compare September = " + x);
            x = s1.CompareTo("Setpember");
            Console.WriteLine("September Compare Setpember = " + x);



            bool flag = s1.Contains("ber");
            Console.WriteLine("Contains- ber " + flag);
            String s2 = s1.Insert(3, " 2017 ");
            Console.WriteLine("Insert " + s2);



            var reversdata = s1.Reverse();
            String s4 = new String(reversdata.ToArray());
            Console.WriteLine("Reverse " + s4);
        }
        public static void SortingStrings()
        {
            //sort the names
            String[] names = new String[5];
            names[0] = "Xavier";
            names[1] = "Basker";
            names[2] = "Anandh";
            names[3] = "John";
            names[4] = "anandh";



            //String temp;
            String temp = String.Empty;
            int len = names.Length;
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < (len - 1); j++)
                {
                    if (names[j].CompareTo(names[j + 1]) > 0)
                    {
                        temp = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < len; i++)
            {
                Console.Write(names[i] + ",");
            }
        }
        public static void ModifyNumberMultipleTimes()
        {
            int begin = DateTime.Now.Millisecond;
            double x = 100;
            for (int i = 1; i < 1000000; i++)
            {
                x += i;
            }
            int after = DateTime.Now.Millisecond;
            Console.WriteLine(after - begin);
            Console.WriteLine(x);
        }
        public static void AssignSameStringMultipleTimes()
        {
            int begin = DateTime.Now.Millisecond;
            String s1 = "Abcd";
            for (int i = 1; i < 1000000; i++)
            {
                //String s2 = "Hello";
                s1 = "Hello";
            }
            int after = DateTime.Now.Millisecond;
            Console.WriteLine(after - begin);
            Console.WriteLine(s1 + " ms");
        }
        public static void ModifyStringMultipleTimes()
        {
            int begin = DateTime.Now.Millisecond;
            String s1 = "Abcd";
            for (int i = 1; i < 1000000; i++)
            {
                s1 += i;
            }
            int after = DateTime.Now.Millisecond;
            Console.WriteLine(after - begin);
            Console.WriteLine(s1 + " ms");
        }
        public static void Firstmethod()
        {
            String s1 = String.Format("{0} ,{1} , {2}", "A", "B", "C");
            Console.WriteLine(s1);
            // Out of Index
            //String s2 = String.Format("{0} ,{1} , {3}", "A", "B", "C");
            //Console.WriteLine(s2);
            // In Valid Input Format
            //String s3 = String.Format("{A , B, C}");
            //Console.WriteLine(s3);
            String x = "Alex";
            String y = $" Hello {x}";
            String s4 = $"Value1:{x} , Value2:{y}";
            Console.WriteLine(s4);
        }
        public static void LeaveLetterTemplate()
        {
            String letter = "Sir,\n As I am suffering from {4} , I want leave for {3} days,\n from {1} to {2}.\n\n Thank You \n {0}";
            String reason = "fever";
            String myName = "Venkat";
            String no_of_Days = "4";
            String fromdate = "6-Aug-2018";
            String todate = "9-Aug-2018";
            String s1 = String.Format(letter, myName, fromdate, todate, no_of_Days, reason);
            Console.WriteLine(s1);
        }
    }
}
