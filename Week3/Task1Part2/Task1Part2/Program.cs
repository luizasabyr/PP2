using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            far FarManager = new far();
            FarManager.Start(@"C:\Users\user\source\repos\PP2");
        }
    }
    class far
    {
        public int cursor;
        public int size;
        public bool ok;
        public far()
        {
            cursor = 0;
            ok = true;
        }
        public void Delete(FileSystemInfo fs)
        {
            if (fs.GetType() == typeof(DirectoryInfo))
                Directory.Delete(fs.FullName, true);
            else
            {
                FileInfo file = new FileInfo(fs.FullName);
                fs.Delete();
            }
        }
        public void TextFile(string path)
        {
            Console.Clear();
            StreamReader sr = new StreamReader(path);
            string s = sr.ReadToEnd();
            Console.WriteLine(s);
            ConsoleKeyInfo k = Console.ReadKey();
            if (k.Key == ConsoleKey.Escape)
            {
                sr.Close();
                return;
            }
            else
                TextFile(path);
        }
        public void Up()
        {
            cursor--;
            if (cursor < 0)
                cursor = size - 1;
        }
        public void Down()
        {
            cursor++;
            if (cursor == size)
                cursor = 0;
        }
        public void Color(FileSystemInfo file, int index)
        {
            if (index == cursor)
                Console.BackgroundColor = ConsoleColor.Red;
            else if (file.GetType() == typeof(DirectoryInfo))
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
        public void Show(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            FileSystemInfo[] files = directory.GetFileSystemInfos();
            size = files.Length;
            int index = 0;
            foreach (FileSystemInfo fs in files)
            {
                Color(fs, index);
                Console.WriteLine(index + 1 + ". " + fs.Name);
                index++;
            }
        }
        public void Start(string path)
        {

            ConsoleKeyInfo key = Console.ReadKey();
            FileSystemInfo fs = null;
            while (key.Key != ConsoleKey.E)
            {
                DirectoryInfo directory = new DirectoryInfo(path);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Show(path);
                if (size != 0)
                {
                    key = Console.ReadKey();
                    fs = directory.GetFileSystemInfos()[cursor];
                    if (key.Key == ConsoleKey.Enter)
                    {
                        if (fs.GetType() == typeof(DirectoryInfo))
                        {
                            cursor = 0;
                            path = fs.FullName;
                        }
                        else if (fs.Name.EndsWith(".txt"))
                            TextFile(fs.FullName);

                    }
                    else if (key.Key == ConsoleKey.Escape)
                    {
                        directory = directory.Parent;
                        path = directory.FullName;
                        cursor = 0;
                    }
                    else if (key.Key == ConsoleKey.Delete)
                    {
                        Delete(fs);
                        FileSystemInfo[] files = directory.GetFileSystemInfos();
                        size = files.Length;
                        cursor = 0;
                    }
                    else if (key.Key == ConsoleKey.N)
                    {
                        string s = Console.ReadLine();
                        ConsoleKeyInfo k = Console.ReadKey();
                        s = Path.Combine(directory.FullName, s);
                        if (fs.GetType() == typeof(DirectoryInfo))
                            Directory.Move(fs.FullName, s);
                        else
                            File.Move(fs.FullName, s);
                    }
                    else if (key.Key == ConsoleKey.UpArrow)
                        Up();
                    else if (key.Key == ConsoleKey.DownArrow)
                        Down();
                }
                else
                {
                    key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Escape)
                    {
                        directory = directory.Parent;
                        path = directory.FullName;
                        cursor = 0;
                    }

                }
            }
        }
    }
}
