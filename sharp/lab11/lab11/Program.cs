using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная 11 Вариант 6\nВведите размерность массива Глубину / Ширину / Длину ");

            //Объявление массива
            int q = int.Parse(Console.ReadLine()); // Глубину
            int i = int.Parse(Console.ReadLine()); // Ширину
            int j = int.Parse(Console.ReadLine()); // Длину
            if (q < 1 || i < 1 || j < 1)
                return;

            //Заполнение массива случайными числами
            int[,,] mass = new int[q, i, j];
            Random random = new Random();
            for (int inxQ = 0; inxQ < q; inxQ++)
            {
                for (int inxI = 0; inxI < i; inxI++)
                {
                    for (int inxJ = 0; inxJ < j; inxJ++)
                    {
                        mass[inxQ, inxI, inxJ] = random.Next(10);
                    }
                }
            }
            printMatrix(ref mass, q, i, j);

            //Нахождение мин и макс элемента массива
            int minValue = mass[0, 0, 0];
            int maxValue = mass[0, 0, 0];
            for (int inxQ = 0; inxQ < q; inxQ++)
            {
                for (int inxI = 0; inxI < i; inxI++)
                {
                    for (int inxJ = 0; inxJ < j; inxJ++)
                    {
                        int element = mass[inxQ, inxI, inxJ];

                        if (element > maxValue)
                            maxValue = element;

                        if (element < minValue)
                            minValue = element;
                    }
                }
            }
            Console.Write("\nМинимальный элемент массива  - {0} \n", minValue);
            Console.Write("Максимальный элемент массива - {0} \n", maxValue);
            Console.ReadKey();
        }

        static void printMatrix(ref int[,,] mass, int q, int i, int j)
        {
            Console.Write("\n");
            for (int inxQ = 0; inxQ < q; inxQ++)
            {
                Console.WriteLine("Глубина " + inxQ);
                for (int inxI = 0; inxI < i; inxI++)
                {
                    for (int inxJ = 0; inxJ < j; inxJ++)
                    {
                        Console.Write(mass[inxQ, inxI, inxJ] + "\t");
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
            }
        }
    }
}
 

                

