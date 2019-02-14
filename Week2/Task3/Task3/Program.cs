using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    class Program
    {
        static void PrintSpaces(int level) //создаем фнукцию PrintSpaces с переменной level типа integer
        {
            for (int i = 0; i < level; i++)//пробегаемся от нуля до level
                Console.Write("  "); //выводим пробелы перед новыми папками
        }

        static void Ex4(DirectoryInfo directory, int level)// создаем рекрусивную фунцию, которая выводит названия и все содержимое в папке
        {
            FileInfo[] files = directory.GetFiles();//берет файлы из заданной директории
            DirectoryInfo[] directories = directory.GetDirectories();//берет папки из заданной директории

            foreach (FileInfo file in files)// пробегаемся по файлам 
            {
                PrintSpaces(level); // вызов функции PrintSpaces
                Console.WriteLine(file.Name); //выводим имя файла
            }

            foreach (DirectoryInfo d in directories)// пробегаемся по папкам 
            {
                PrintSpaces(level);// вызов функции PrintSpaces
                Console.WriteLine(d.Name);//выводим имя папки
                Ex4(d, level + 1);//вызов функции Ex4 
                //добавляем к левелу 1 , чтобы при каждой открытии папки он выводил их на новый уровень, то есть на след строку
            }
        }

        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\Users\user\source\repos\PP2");//указываем путь
            Ex4(d, 0);//вызов функции Ex4 
            //начинаем отступ с нулевого уровня

        }
    }
}
