using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная 10 Вариант 6\nВведите M / N");
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            if (m < 1 || n < 1)
                return;

            int[,] mass = new int[m, n];
            Random random = new Random();
            for (int inxM = 0; inxM < m; inxM++)
            {
                for (int inxN = 0; inxN < n; inxN++)
                {
                    mass[inxM, inxN] = random.Next(10);
                }
            }
            printMatrix(ref mass, m, n);

            int minimalMatrixValue = mass[0, 0];
            for (int inxM = 0; inxM < m; inxM++)
            {
                int minimalLineValue = mass[inxM, 0];
                for (int inxN = 0; inxN < n; inxN++)
                {
                    int currentElement = mass[inxM, inxN];
                    if (minimalLineValue > currentElement)
                        minimalLineValue = currentElement;
                }
                if (minimalLineValue < minimalMatrixValue)
                    minimalMatrixValue = minimalLineValue;
                Console.WriteLine("Min for" + inxM + ": " + minimalLineValue);
            }

            for (int inxM = 0; inxM < m; inxM++)
            {
                for (int inxN = 0; inxN < n; inxN++)
                {
                    int currentElement = mass[inxM, inxN];
                    if (currentElement % 3 == 0) //Равен ли остаток от деления 0 - если равен присваиваем текущему элементу минимальный элемент матрицы
                        mass[inxM, inxN] = minimalMatrixValue;
                }
            }
            printMatrix(ref mass, m, n);

            Console.ReadLine();
        }

        static void printMatrix(ref int[,] mass, int m, int n)
        {
            Console.Write("\n");
            for (int inxM = 0; inxM < m; inxM++)
            {
                for (int inxN = 0; inxN < n; inxN++)
                {
                    Console.Write(mass[inxM, inxN] + "\t");
                }
                Console.Write("\n");
            }
        }
    }
}
