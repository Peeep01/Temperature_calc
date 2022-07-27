using System;

namespace Temperature_calculator
{
    internal class Program
    {
       public static void Main(string[] args)
       {
            while (true)
            {
                Console.Write("Введите число по цельсию: ");
                int celsius = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Кельвин = {0}", celsius + 273);
                Console.WriteLine("Фаренгейт = {0}", celsius * 18 / 10 + 32);
                
            }
            
       }
    }
}
