using System;
using System.Collections.Generic;

namespace LABA
{
  class User
    {
        public string login, name, lastname;
        public int date, age;
    }
    class Program
    {
        static User GetUser()
        {
            var user = new User();
            user.login = "Superman228";
            user.name = "Ivan";
            user.lastname = "Shevchenko";
            user.age = 18;
            user.date = 2022;
            return user;
        }
        static void Print (User user)
        {
            Console.WriteLine("iнформацiя про користувача: ");
            Console.WriteLine($"Login: {user.login}");
            Console.WriteLine($"Name: {user.name}");
            Console.WriteLine($"LastName: {user.lastname}");
            Console.WriteLine($"Age: {user.age}");
            Console.WriteLine($"Date of Registration: {user.date}");
        }
        static void Main(string[] args)
        {
            var info = GetUser();
            Print(info);
        }
    }
}
