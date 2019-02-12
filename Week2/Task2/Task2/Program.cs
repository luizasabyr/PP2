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
        public static bool Ex(int a)
        {
            int k = 0;
            for (int j = 1; j <= a; j++)
            {
                if (a % j == 0)
                {
                    k++;

                }
            }
            if (k == 2)
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
            string[] arr = s.Split();
            // выводим все простые числа в другом файле
            StreamWriter sw = new StreamWriter("output.txt");
            for (int i = 0; i < arr.Length; i++)
            {
                if (Ex(int.Parse(arr[i])) == true)
                {
                    sw.Write(arr[i] + " ");
                }
            }
            sw.Close();
        }
    }
}
