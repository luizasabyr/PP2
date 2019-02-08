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
            string[] lines = File.ReadAllLines(@"C:\Users\user\source\repos\PP2\Week2\Task1\Task1\bin\Debug\a.txt");

            foreach (string line in lines)
            {
                char[] charArray = line.ToCharArray();
                for (int i = 0; i < 1; i++)
                {
                    Array.Reverse(charArray);
                    bool a = charArray.SequenceEqual(line);
                    while (a == true)
                    {
                        Console.WriteLine(line); 
                        Console.WriteLine("YES");
                        break;
                    }
                    while (a == false)
                    {
                        Console.WriteLine(line); 
                        Console.WriteLine("NO");
                        break;
                    }

                }
            }
        }
    }
}
