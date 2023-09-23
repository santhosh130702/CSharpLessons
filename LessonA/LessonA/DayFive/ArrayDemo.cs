﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DayFive
{
    internal class ArrayDemo
    {
        public static void FirstMethod()
        {
            int[] samples = new int[10];
            int length = samples.Length;
            int i;
            Random random = new Random();   
            for(i = 0; i < length; i++)
            {
                samples[i] = random.Next(100);
            }
            for(i = 0; i < length;i++) {

                Console.WriteLine("sample[" + i + "]:" + samples[i]);
            }
            Console.WriteLine("sum:"+samples.Sum());
            Console.WriteLine("average:" + samples.Average());
            Console.WriteLine("max:" + samples.Max());
            Console.WriteLine("min:" + samples.Min());
        }
        public static void ArrayOver()
        {
            int[] samples = new int[10];
            int i;
            for(i=0;i<100;i++) {
                Console.WriteLine(samples[i]);
            }
        }
        public static void WorkingWithCharArray()
        {
            string s1 = "Today is a very hot day";
            char[] data = s1.ToCharArray();
            int count = data.Length;
            Console.WriteLine("Array Length " + count);
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(data[i]);
            }
        }
        public static void TwoD()

        {

            int t, i;

            int[,] table = new int[3, 4];//3 Rows - 4 Col

            for (t = 0; t < 3; ++t)

            {

                for (i = 0; i < 4; ++i)

                {

                    table[t, i] = t * 4 + i + 1;

                    //Console.Write(table[t, i] + " ");

                }

                Console.WriteLine();

            }

        }


       public static void ThreeD()

        {

            int[,,] m = new int[3, 3, 3];

            //int sum = 0;

            int n = 1;

            #region a

            //m[0, 0, 0] = 1; m[0, 0, 1] = 2; m[0, 0, 2] = 3;

            //m[0, 1, 0] = 4; m[0, 1, 1] = 5; m[0, 1, 2] = 6;

            //m[0, 2, 0] = 7; m[0, 2, 1] = 8; m[0, 2, 2] = 9;



            //m[1, 0, 0] = 10; m[1, 0, 1] = 11; m[1, 0, 2] = 12;

            //m[1, 1, 0] = 13; m[1, 1, 1] = 14; m[1, 1, 2] = 15;

            //m[1, 2, 0] = 16; m[1, 2, 1] = 17; m[1, 2, 2] = 18;



            //m[2, 0, 0] = 19; m[2, 0, 1] = 20; m[2, 0, 2] = 21;

            //m[2, 1, 0] = 22; m[2, 1, 1] = 23; m[2, 1, 2] = 24;

            //m[2, 2, 0] = 25; m[2, 2, 1] = 26; m[2, 2, 2] = 27;



            #endregion

            for (int x = 0; x < 3; x++)

            {

                for (int y = 0; y < 3; y++)

                {

                    for (int z = 0; z < 3; z++)

                    {

                        m[x, y, z] = n++;

                    }

                }

            }

            for (int x = 0; x < 3; x++)

            {

                for (int y = 0; y < 3; y++)

                {

                    for (int z = 0; z < 3; z++)

                    {

                        Console.Write(m[x, y, z] + " ,");

                    }

                    Console.WriteLine();

                }

            }

        }
        public static void UsingJaggedArrays()
        {
            int[][] jagged = new int[3][];
            jagged[0] = new int[4];
            jagged[1] = new int[3];
            jagged[2] = new int[5];
            int i;
            // Store values in first array.
            for (i = 0; i < 4; i++)
                jagged[0][i] = i;
            // Store values in second array.
            for (i = 0; i < 3; i++)
                jagged[1][i] = i;
            // Store values in third array.
            for (i = 0; i < 5; i++)
                jagged[2][i] = i;
            // Display values in first array.
            for (i = 0; i < 4; i++)
                Console.Write(jagged[0][i] + " ");
            Console.WriteLine();
            // Display values in second array.
            for (i = 0; i < 3; i++)
                Console.Write(jagged[1][i] + " ");
            Console.WriteLine();
            // Display values in third array.
            for (i = 0; i < 5; i++)
                Console.Write(jagged[2][i] + " ");
            Console.WriteLine();
        }
        public static void SortingArrays()
        {
            int[] nos = { 32, 21, 10, 56, 87, 43, 97, 2 };
            Console.WriteLine("B4 sort ");
            int len = nos.Length;
            for (int i = 0; i < len; i++)
            {
                Console.Write(nos[i] + ",");
            }
            Console.WriteLine();
            Array.Sort(nos);
            Console.WriteLine("After sort ");



            len = nos.Length;
            for (int i = 0; i < len; i++)
            {
                Console.Write(nos[i] + ",");
            }
            Console.WriteLine();
        }
        public static void EmpArray()
        {
            Emp[] elist = new Emp[10];
            for (int i = 0; i < 10; i++)
            {
                Emp e1 = new Emp(i);
                e1.FirstName = "Emp" + i;
                elist[i] = e1;
            }



            Console.WriteLine("No of Employees " + elist.Length);
            for (int i = 0; i < 10; i++)
            {
                Emp e1 = elist[i];
                Console.WriteLine("ID=" + e1.GetID() + " Name=" + e1.FirstName);
            }
        }
    }
}
