using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student // создаем класс Student
    {
        
            string name; // строка name
            string id; // строка id
            int year = 1; // переменный integer year равный одному

            public Student(string name, string id) //  конструктор с параметрами name  и id
            {
             this.name = name; 
                                  //доступ к текущему экземпляру класса
             this.id = id;     
            }
            public void new_year() //  конструктор без параметров
            {
                while (year <= 4)
                {
                    Console.WriteLine(name + " " + id + " " + year);
                    year++;
                } //выводим имя,id и год обучения,пока год равен или меньше 4.И увеличиваем год на 1 .
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Student s1 = new Student("Sabyr Luiza", "18BD110542"); // новый студент с данными
                s1.new_year();  // вызов функции new_year
            }
        }
    }
