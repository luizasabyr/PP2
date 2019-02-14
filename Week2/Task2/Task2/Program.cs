using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    {
        public static bool Ex(int a)//создаем функцию булеан Ex с переменной а
        {
            int k = 0; //создаем переменную к, равному 0, которая считывает число делителей 
            for (int j = 1; j <= a; j++) //пробегаемся от 1 до а
            {
                if (a % j == 0)//если а делится на j без остатка , то увеличиваем к на 1
                {
                    k++;

                }
            }
            if (k == 2) // если к равно 2 то считываем как true , иначе false
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // создаем функцию, чтобы прочесть числа из файла
        public static string Read()
        {
            StreamReader sr = new StreamReader("input.txt");
            string s = sr.ReadToEnd();
            sr.Close();
            return s;
        }
        static void Main(string[] args)
        {
            String s = Read();
            string[] arr = s.Split();//разделяем строку на подстроки 
            
            StreamWriter sw = new StreamWriter("output.txt");// выводим все простые числа в другом файле
            for (int i = 0; i < arr.Length; i++)
            {
                if (Ex(int.Parse(arr[i])) == true)//вызываем функцию Ex ,превращая элементы массива в integer с помощью Parse
                {
                    sw.Write(arr[i] + " ");//выводим простые числа через пробел
                }
            }
            sw.Close();//закрываем текущий StreamWriter и основной поток
        }
    }
}
