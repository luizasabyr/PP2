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
        static void PrintSpaces(int level)
        {
            for (int i = 0; i < level; i++)
                Console.Write("  ");
        }

        static void Ex4(DirectoryInfo directory, int level)
        {
            FileInfo[] files = directory.GetFiles();
            DirectoryInfo[] directories = directory.GetDirectories();

            foreach (FileInfo file in files)
            {
                PrintSpaces(level);
                Console.WriteLine(file.Name);
            }

            foreach (DirectoryInfo d in directories)
            {
                PrintSpaces(level);
                Console.WriteLine(d.Name);
                Ex4(d, level + 1);
            }
        }

        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\Users\user\source\repos\PP2");
            Ex4(d, 0);

        }
    }
}
