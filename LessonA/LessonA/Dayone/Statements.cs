﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LessonA.Dayone
{
    internal class Statements
    {/**
        public static void TestOne()
        {
            Console.WriteLine("enter the age");
            string agestring = Console.ReadLine();
            if (!IsNumeric(agestring))
            {
                return;
            }
            int age = int.Parse(agestring);
            if (age<18)
            {
                Console.WriteLine("sorry you cant drive");
            }
            else
            {
                Console.WriteLine("yes,you can drive");
            }
        }
        public static bool IsNumeric(String pValue)
        {
            bool result = false;
            if (pValue == null)
            {
                Console.WriteLine("INVALID String!!! Value is NULL....");
                return false;
            }
            char[] data = pValue.ToCharArray();
            int length = data.Length;
            for (int i = 0; i < length; i++)
            {
                char c1 = data[i];
                int ascii = (int)c1;
                if (ascii < 48 || ascii > 57)
                {
                    Console.WriteLine("Value is not a NUMBER!!!");
                    return false;
                }
            }
            result = true;
            return result;
        }
        public static void DoLogin()
        {
            Console.WriteLine("Enter Your Name");
            String name = Console.ReadLine();
            bool flag = CheckName(name);
            if (!flag)
            {
                return;
            }
            Console.WriteLine("Enter Your PASSWORD");
            String pwd = Console.ReadLine();
            flag = CheckPassword(pwd);
            if (!flag)
            {
                return;
            }
            Console.WriteLine($"Welcome {name} Your Password is {pwd}");
        }
        public static bool CheckName(String name)
        {
            bool result = false;
            if (string.IsNullOrEmpty(name))
            {
                result = false;
                Console.WriteLine("Name is NULL or EMPTY");
            }
            name = name.Trim().ToLower();
            char[] chars = name.ToCharArray();
            int length = chars.Length;
            if (length < 3 || length > 15)
            {
                Console.WriteLine("Name Length Must be between 3 and 15!!!");
                result = false;
                return result;
            }
            for (int i = 0; i < length; i++)
            {
                int ascii = chars[i];
                if (ascii < 97 || ascii > 122)
                {
                    Console.WriteLine($"Invalid char in NAME {chars[i]}");
                    result = false;
                    return result;
                }
            }
            result = true;
            return result;
        }
        public static bool CheckPassword(String pwd)
        {
            bool result = false;
            int numberCount = 0;
            int upperCaseCount = 0;
            int lowerCaseCount = 0;
            int symbolCount = 0;
            if (string.IsNullOrEmpty(pwd))
            {
                result = false;
                Console.WriteLine("Password is NULL or EMPTY");
            }
            pwd = pwd.Trim();
            char[] chars = pwd.ToCharArray();
            int length = chars.Length;
            if (length < 8 || length > 15)
            {
                Console.WriteLine("Password Length Must be between 8 and 15!!!");
                result = false;
                return result;
            }
            for (int i = 0; i < length; i++)
            {
                int ascii = chars[i];
                if (ascii > 64 || ascii <= 90)
                {
                    upperCaseCount++;
                }
                if (ascii > 95 || ascii <= 122)
                {
                    lowerCaseCount++;
                }
                if (ascii > 47 || ascii <= 58)
                {
                    numberCount++;
                }
                if (chars[i] == '$' || chars[i] == '@' || chars[i] == '%' || chars[i] == '*' || chars[i] == '_')
                {
                    symbolCount++;
                }
            }
            if (upperCaseCount == 0 || lowerCaseCount == 0 || symbolCount == 0 || numberCount == 0)
            {
                Console.WriteLine("Password Must atleast 1 UPPERCASE / NUMBER / Special CASE / LOWERCASE !!!");
                result = false;
                return result;
            }
            result = true;
            return result;
        }
        static bool IsLetter(char c)
        {
            return (c >= 'a' && c <= 'z') || (c >= 'a' && c <= 'z');
        }



        static bool IsDigit(char c)
        {
            return c >= '0' && c <= '9';
        }



        static bool IsSymbol(char c)
        {
            return c > 32 && c < 127 && !IsDigit(c) && !IsLetter(c);
        }



        static bool IsValidpassword(string password)
        {
            return
               password.Any(c => IsLetter(c)) &&
               password.Any(c => IsDigit(c)) &&
               password.Any(c => IsSymbol(c));
        }
        public static bool CheckPasswordUsingRegEx(string password)
        {
            Regex sampleRegex = new Regex(@"(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{2,})$");
            bool isStrongPassword = sampleRegex.IsMatch(password);
            return isStrongPassword;
        }

        public static void ForLoopdemo()
        {
            for(int i=1;)
        }**/
        public static void Pyramid()
        {
            string row1 = Console.ReadLine();
            int row2 = int.Parse(row1);
            Console.WriteLine(row2);
            
            for(int i = 1; i <= row2; i++)
            {
                for(int j = 1; j <= row2- i; j++)
                {
                    Console.Write(" ");
                }

                for(int j = i; j >= 1; j--)
                {
                    Console.Write(j);
                }

                for(int j = 2; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }


        }
        public static void Integers()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Grapes");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Apple");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Orange");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
