﻿using Lesson28.Day28;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson28.Day28
{
    internal class ArrayConcepts
    {
        public static void FirstMethod()
        {
            int[] sample = new int[10];      // 10 is size of array
            //int a[] = new int[10]; // Illigal it is in Java
            int length = sample.Length;
            int i;
            Random random = new Random(); // Used to generate a random number at runtime
            for (i = 0; i < 10; i = i + 1)
                sample[i] = random.Next(100);
            for (i = 0; i < 10; i++)
                Console.WriteLine("sample[" + i + "]: " + sample[i]);
            Console.WriteLine("Sum:"+sample.Sum());
            Console.WriteLine("Average:"+sample.Average());
            Console.WriteLine("Max:"+sample.Max());
            Console.WriteLine("Min:" + sample.Min());
        }
        public static void ArrayOverRun()
        {
            int[] sample = new int[10];
            int i;
            // Generate an array overrun.
            for (i = 0; i < 100; i = i + 1)
                sample[i] = i;
            //IndexOutOfRangeException
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
    }

}
class Emp
{
    private readonly double Id;
    public string Name;
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public double Salary { get; set; }
    public int ID { get; internal set; }

    public Emp() { }
    public Emp(double v1)
    {
        Id = v1;
    }
    public double GetID()
    {
        return Id;
    }

}
//using Lesson28.Day28;
//ArrayConcepts.FirstMethod();
//ArrayConcepts.ArrayOverRun(); //It shows array out of index
//ArrayConcepts.WorkingWithCharArray();
//ArrayConcepts.TwoD();
//ArrayConcepts.ThreeD();
//ArrayConcepts.UsingJaggedArrays();
//ArrayConcepts.SortingArrays();
//ArrayConcepts.EmpArray();
//ArrayConcepts.SetStringDemo();
//ArrayConcepts.TestGenericSortedSetString();
//ArrayConcepts.TestGenericSortedSetInt();