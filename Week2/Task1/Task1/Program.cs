using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("a.txt");//считываем с файла данные

            foreach (string line in lines)//пробегаемся по строке 
            {
                char[] charArray = line.ToCharArray();//копирует знаки данного экземпляра в массив знаков юникода
                for (int i = 0; i < 1; i++) //пробегаемся по каждой строке по одному разу
                {

                    Array.Reverse(charArray);//изменяем порядок элементов массива Array на обратный и проверяем
                    bool a = charArray.SequenceEqual(line);//сравнивает последовательности на равенство элементов
                    while (a == true)//пока последовательности равны выводим строку и слово "YES"
                    {
                        Console.WriteLine(line); 
                        Console.WriteLine("YES");
                        break;//останавливаем код
                    }
                    while (a == false)//пока последовательности не равны выводим строку и слово "NO"
                    {
                        Console.WriteLine(line); 
                        Console.WriteLine("NO");
                        break;//останавливаем код
                    }

                }
            }
        }
    }
}
