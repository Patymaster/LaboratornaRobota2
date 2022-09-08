using System;
using System.Collections.Generic;

namespace LABA
{
    class Converter
    {
       public double usd, eur, rub;
      public void Buy()
        {
            usd = 41.00;
            eur = 40.60;
            rub = 0.30;
        }
        public void Sell()
        {
            usd = 40.45;
            eur = 39.80;
            rub = 0.28;
        }
    }
      
    
    class Program
    {
    static void Main(string[] args)
        {
            Converter Curs = new Converter();
            Console.WriteLine("Оберiть валюту: \n1:USD\n2:EUR\n3:RUB");
            int valuta = Convert.ToInt32(Console.ReadLine());
            if(valuta == 1)
            {
                Console.WriteLine("Що ви хочете зробити? \n1:Купити\n2:Продати");
                int diya = Convert.ToInt32(Console.ReadLine());
                if(diya == 1)
                {
                    Console.WriteLine("Ведiть Скiльки хочете купити:");
                    int suma = Convert.ToInt32(Console.ReadLine());
                    Curs.Buy();
                    double itog = suma * Curs.usd;
                    Console.WriteLine($"З вас: {itog}");
                }
                else if (diya == 2)
                {
                    Console.WriteLine("Ведiть Скiльки хочете продати:");
                    int suma = Convert.ToInt32(Console.ReadLine());
                    Curs.Sell();
                    double itog = suma * Curs.usd;
                    Console.WriteLine($"Ви отримаєте: {itog}");
                }
                else
                    Console.WriteLine("Невiрне значеня");
            }else if (valuta == 2)
            {
                Console.WriteLine("Що ви хочете зробити? \n1:Купити\n2:Продати");
                int diya = Convert.ToInt32(Console.ReadLine());
                if (diya == 1)
                {
                    Console.WriteLine("Ведiть Скiльки хочете купити:");
                    int suma = Convert.ToInt32(Console.ReadLine());
                    Curs.Buy();
                    double itog = suma * Curs.eur;
                    Console.WriteLine($"З вас: {itog}");
                }
                else if (diya == 2)
                {
                    Console.WriteLine("Ведiть Скiльки хочете продати:");
                    int suma = Convert.ToInt32(Console.ReadLine());
                    Curs.Sell();
                    double itog = suma * Curs.eur;
                    Console.WriteLine($"Ви отримаєте: {itog}");
                }
                else
                    Console.WriteLine("Невiрне значеня");
            }
            else if (valuta == 3)
            {
                Console.WriteLine("Що ви хочете зробити? \n1:Купити\n2:Продати");
                int diya = Convert.ToInt32(Console.ReadLine());
                if (diya == 1)
                {
                    Console.WriteLine("Ведiть Скiльки хочете купити:");
                    int suma = Convert.ToInt32(Console.ReadLine());
                    Curs.Buy();
                    double itog = suma * Curs.rub;
                    Console.WriteLine($"З вас: {itog}");
                }
                else if (diya == 2)
                {
                    Console.WriteLine("Ведiть Скiльки хочете продати:");
                    int suma = Convert.ToInt32(Console.ReadLine());
                    Curs.Sell();
                    double itog = suma * Curs.rub;
                    Console.WriteLine($"Ви отримаєте: {itog}");
                }
                else
                    Console.WriteLine("Невiрне значеня");
            }else
                Console.WriteLine("Невiрне значеня");

        }
    }
}

