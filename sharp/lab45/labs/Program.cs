using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs
{
    class Program
    {
        static void Main(string[] args)
        {
            int exitCode = 0;
            int x = 0;
            int y = 0;

            //Лабораторная 4 / 5
            do //for(;;) { *** if(exitCode != 1) break; } - если нужно через for
            {
                Console.WriteLine("Лабораторная 4/5 - Вариант 6");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("z = " + (new LabFourVarSix(x, y, n).getZ()) + "\n Выйти из программы? 1 - выйти");
                exitCode = int.Parse(Console.ReadLine());
            } while (exitCode != 1);
            //////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }

    class LabFourVarSix
        {
            public LabFourVarSix(int _x, int _y, int _n)
            {
                x = _x;
                y = _y;
                n = _n;
            }

            public double getZ()
            {
                double z = 0;
                for (int inx = 1; inx <= n; ++inx)
                {
                    if (inx % 2 == 0)
                        z += getIteration(inx);
                    else
                        z -= getIteration(inx);
                }
                return 1 - z;
            }

            private double getIteration(int iterationValue)
            {
                decimal numerator = (ulong)((iterationValue % 2 == 0) ? y * y : x * x);
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
            public int y;
            public int n;
        }

    } 