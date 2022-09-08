using System;
using System.Collections.Generic;


namespace Zadacha1
{
    class Address
    {
        private int index = 07700;
        private string country = "Ukraine", city = "Yagotyn", street = "Shevchenka", house = "26", apartment = "1";
        public void address()
        {
            Console.WriteLine("Address: ");
            Console.WriteLine($"index: {index}");
            Console.WriteLine($"country: {country}");
            Console.WriteLine($"city: {city}");
            Console.WriteLine($"street: {street}");
            Console.WriteLine($"house: {house}");
            Console.WriteLine($"apartment: {apartment}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Address A = new Address();
            A.address();
        }
    }

}
