using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная 11 Вариант 6\nВведите количество строк");
            int i = int.Parse(Console.ReadLine());
            int[][] mass = new int[i][];
            Random random = new Random();
            //Заполнили зубчатый массив
            for (int inxI = 0; inxI < i; inxI++)
            {
                Console.WriteLine("Введите количество элементов для строки {0}", inxI);
                int j = int.Parse(Console.ReadLine());
                mass[inxI] = new int[j];
                for (int inxJ = 0; inxJ < j; inxJ++)
                {
                    mass[inxI][inxJ] = random.Next(10);
                }
            }

            Console.Write("\n");
            //Вывели на экран зубчатый массив
            for (int inxI = 0; inxI < i; inxI++)
            {
                int length = mass[inxI].Length;
                int sum = 0;
                for (int inxJ = 0; inxJ < length; inxJ++) //foreach написать так
                {
                    int element = mass[inxI][inxJ];
                    sum += element;
                    Console.Write("{0}\t", element);
                }
                Console.Write("\t\t\tсумма элементов:{0}\n", sum);
            }
            Console.ReadLine();
        }
    }
}
