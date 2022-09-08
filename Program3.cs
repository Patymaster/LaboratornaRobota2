using System;
using System.Collections.Generic;

namespace LABA
{
  class Employee
    {
        public string LastName, FirstName;
        public float oklad, stazh;
    }
    class Program
    {

        static void Main(string[] args)
        {
            var employ = new Employee();
            Console.WriteLine("Введiть iм'я: ");
            employ.FirstName = Console.ReadLine();
            Console.WriteLine("Введiть прiзвище: ");
            employ.LastName = Console.ReadLine();
            Console.WriteLine("Введiть стаж(рокiв): ");
            employ.stazh = Convert.ToInt32(Console.ReadLine());
            float index = 1;
            if (employ.stazh <= 1)
                index = 1.1f;
            else if (employ.stazh > 1 && employ.stazh < 5)
                index = 1.3f;
            else if (employ.stazh >= 5)
                index = 2f;
            employ.oklad = 20000f * index * 0.8f;
            Console.WriteLine($"iм'я: {employ.FirstName}");
            Console.WriteLine($"прiзвище: {employ.LastName}");
            Console.WriteLine($"Оклад: {employ.oklad}");
            Console.WriteLine($"Збiр: {(20000*index)-employ.oklad}");
        }
    }


}
