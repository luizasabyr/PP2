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
            string s = Console.ReadLine();
            int a = int.Parse(s);
            string[] arr = Console.ReadLine().Split();
            int sum = 0;
            for (int i = 0; i < a; i++)
            {
                 
                for (int j = 2; j < (int)i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        break;
                    }
                    else
                    {
                        sum++;
                        Console.WriteLine(sum);


                    }
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}
