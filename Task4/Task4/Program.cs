using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//создав новую переменную, считываем ее со строки и превращаем ее в целое число
            for (int i = 0; i < n; i++) // пробегаемся от нуля до n   в ряду 
            {
                for (int j = 0; j < i + 1; j++) // пробегаемся от нуля до i+1, по столбцу
                {
                    Console.Write("[*]"); // выводим [*] относительно по порядку рядов
                }
                Console.WriteLine();// каждый ряд [*] начинаем с новой строки
            }
        }
    }
}
