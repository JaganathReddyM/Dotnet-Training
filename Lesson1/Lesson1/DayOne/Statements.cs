﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Lesson1.DayOne
{
    internal class Statements
    {
        public static void TestOne()
        {
            Console.WriteLine("Enter Your AGE");
            String ageAsString = Console.ReadLine();
            if(IsNumeric(ageAsString))
            {
                return;
            }
            int age = int.Parse(ageAsString);
            if (age < 18 )
            {
                Console.WriteLine("SORRY!!! You cant drive");
            }
            else
            {
                Console.WriteLine("You can Drive");
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
    }
}

/*
 * Statements.TestOne();*/