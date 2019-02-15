using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            far FarManager = new far(); //создаем FarManager
            FarManager.Start(@"C:\Users\user\source\repos\PP2");//задаем путь с адресом
        }
    }
    class far //создаем класс
    {
        public int cursor;
        public int size;    // создаем переменные курсор,size,ok 
        public bool ok;
        public far()
        {
            cursor = 0; //вначале курсор должен стоять на верху поэтому cursor=0
            ok = true;
        }
        public void Up() //создаем метод для того чтобы передвигать курсор вверх
        {
            cursor--; //если курсор -- то он поднимется вверх
            if (cursor < 0)//если курсор меньше нуля то при нажатии кнопку вверх курсор должен попасть в самый низ поэтому size-1
                cursor = size - 1; 
        }
        public void Down()//метод для передвигании вниз
        {
            cursor++; //если курсор ++ то он спускается вниз
            if (cursor == size) //если курсор равен всему размеру тоесть количеству всех файлов и папок то при нажатии кнопку вниз курсор должен оказатся в самом верху
                cursor = 0;//поэтому курсор =0
        }
        public void Color(FileSystemInfo file, int index) //создаем функцию для цветов
        {
            if (index == cursor) //если курсор равен индексу то задний фон должен быть серого цвета
                Console.BackgroundColor = ConsoleColor.Gray;
            else if (file.GetType() == typeof(DirectoryInfo))
            {
                Console.ForegroundColor = ConsoleColor.White; //папки белого цвета
                Console.BackgroundColor = ConsoleColor.DarkBlue;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;//файлы желтого
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
        public void Show(string path) //создаем функцию которая показывает нам файлы
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            FileSystemInfo[] files = directory.GetFileSystemInfos();//показываем все файлы и подкаталоги в том или ином каталоге
            size = files.Length; 
            int index = 0;
            foreach (FileSystemInfo fs in files)// пробегаемся по файлам
            {
                Color(fs, index); //вызов функции Color
                Console.WriteLine(fs.Name);
                index++;
            }
        }
        public void Start(string path) //функция старт для клавиш
        {
            ConsoleKeyInfo key = Console.ReadKey();// при нажатии кнопку E вся работа останавливается
            FileSystemInfo fs = null;
            while (key.Key != ConsoleKey.E)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Show(path);
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow) //вызов функции передвигания
                    Up();
                else if (key.Key == ConsoleKey.DownArrow)
                    Down();

            }
        }
    }
}
