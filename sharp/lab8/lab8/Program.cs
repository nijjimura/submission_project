using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная 8 Вариант 6 \n 1 - выбор первого выражения \n 2 - выбор 2го выражения");
            double z = 0;
            int selection = int.Parse(Console.ReadLine());
            if (selection == 1)
                z = new LabEightVarSixPartOne().getExpression();
            else if (selection == 2)
                z = new LabEightVarSixPartTwo().getExpression();
            Console.WriteLine("Z = " + z);
            Console.ReadLine();
        }
    }
    class LabEightVarSixPartTwo
    {
        public LabEightVarSixPartTwo()
        {
            Console.WriteLine("Выражение 2 - Введите N / R");
            n = int.Parse(Console.ReadLine());
            r = int.Parse(Console.ReadLine());
        }

        public double getExpression()
        {
            double result = 0;
            for (int i = 1; i <= n; ++i)
            {
                for (int j = 1; j <= r; ++j)
                {
                    double numerator = i * i + j * j;
                    double denominator = i * i * i + j * j * j;
                    result += numerator / denominator;
                }
            }
            return result;
        }

        private int n;
        private int r;
    }

    class LabEightVarSixPartOne
    {
        public LabEightVarSixPartOne()
        {
            Console.WriteLine("Выражение 1 - Введите x / p / n");
            x = int.Parse(Console.ReadLine());
            p = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
        }

        public double getExpression()
        {
            double z = 0;
            for (int inx = 1; inx <= n; ++inx)
            {
                if (inx % 2 == 0)
                    z += getIteration(inx);
                else
                    z -= getIteration(inx);
            }
            return z;
        }

        private double getIteration(int iterationValue)
        {
            decimal numerator = (ulong)(Math.Pow(p, iterationValue - 1) * Math.Pow(x, iterationValue));
            decimal denomerator = getFactorial(iterationValue);
            double result = (double)(numerator / denomerator);
            return result;
        }

        private decimal getFactorial(int iterationValue) //Переполнение возможно
        {
            ulong factorial = 1;
            for (int inx = 1; inx <= iterationValue + 1; ++inx)
            {
                factorial *= (ulong)inx;
            }
            return factorial;
        }

        public int x;
        public int p;
        public int n;
    }
}
