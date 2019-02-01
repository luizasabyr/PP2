using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//создав новую переменную, считываем ее со строки и превращаем ее в целое число
            int[] arr = new int[n];//создаем новый массив целых чисел
            string[] array = Console.ReadLine().Split();//считываем каждый элемент строки, как отдельный член массива
            for (int i = 0; i < n; i++)//пробегаемся по массиву
            {
                arr[i] = int.Parse(array[i]);//превращаем каждый элемент массива со string в integer
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " " + arr[i] + " ");//выводим каждый элемент массива по два раза в одну строку
            }
        }
    }
}
     