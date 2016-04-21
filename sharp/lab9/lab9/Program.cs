using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная 9 Вариант 6 \n Введите длину массива");
            int length = int.Parse(Console.ReadLine());
            int[] mass = new int[length];
            Random random = new Random();
            for(int inx = 0; inx < length; inx++)
            {
                int value = random.Next(10);
                mass[inx] = value;
                Console.Write(value + "\t");
            }

            int summ = 0;
            for(int inx = 0; inx < length; inx++) //Все можно организовать в одном цикле, но тогда нет смысла в массиве ^_^
            {
                summ += mass[inx];
            }
            Console.WriteLine("\n" + summ);
            Console.ReadLine();
        }
    }
}
