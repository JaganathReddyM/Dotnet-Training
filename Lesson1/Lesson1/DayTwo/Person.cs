﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.DayTwo
{
    internal class Person
    {
        public int Id { get; set; } 
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public long Phone { get; set; } 
        public override string ToString()
        {
            return $"ID:{this.Id}, Name:{Title} {FirstName} {LastName},\n"+
                $"Address:{Address},City:{City}, State:{Region}, \n" +
                $"Phone:{Phone}, Country:{Country}, Zip{PostalCode}";
        }

    }
    internal class TestPerson
    {
        public static void TestOne()
        {
            Person firstperson = new Person();
            firstperson.Id = 1;
            firstperson.FirstName = "Jaganath";
            firstperson.LastName = "Mandaluri";
            firstperson.Address = "Kurnool";
            firstperson.City = "Nandyal";
            firstperson.Country = "India";
            firstperson.Phone = 934780833L;
            firstperson.PostalCode = "518 346";
            firstperson.Region = "Andhra";
            firstperson.Title = "Mr";
            String value=firstperson.ToString();
            Console.WriteLine(value);


        }
    }
}
