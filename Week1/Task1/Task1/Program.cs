using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {

        static void Main(string[] args)
        {
            string s = Console.ReadLine();//ввод количество элементов в массиве
            int a = int.Parse(s); //превращаем количество элементов в массиве со стринга в int
            int[] array = new int[a]; //создаем новый массив 
            string[] arr = Console.ReadLine().Split(); //ввод элементов массива 

            for (int i = 0; i < a; i++)//пробегаемся по массиву
            {
                array[i] = int.Parse(arr[i]);// превращаем элемента массива в int
            }
            int sum = 0; //новый переменный cчетчик для количества простых чисел
            for (int i = 0; i < a; i++)
            {
                int n = 0;//создаем новый переменный для количества делителей числа
                for (int j = 1; j <= array[i]; j++)//пробегаемся от 1 до самого числа, чтобы найти делителей данного числа
                {
                    if (array[i] % j == 0)//если число делится без остатков, то увеличиваем переменную n на 1
                    {
                        n++;
                    }
                }
                if (n == 2)
                {
                    sum++;
                }//если количество делителей равно 2, то число является простым, поэтому увеличиваем переменную sum на 1

            }
            Console.WriteLine(sum);// выводим sum


            //дальше все это повторяем для того, чтобы выводить простые числа из заданного элементов массива

            for (int i = 0; i < a; i++)
            {
                int n = 0;
                for (int j = 1; j <= array[i]; j++)
                {
                    if (array[i] % j == 0)
                    {
                        n++;
                    }
                }
                if (n == 2)
                {

                    Console.Write(array[i] + " ");// выводим простые числа из элементов массива через пробел
                }


            }
        }
    }
}
