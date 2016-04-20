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

            //Лабораторная 6/7
            Console.WriteLine("Лабораторная 6/7 - Вариант 6");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            LabSixVarSix labSix = new LabSixVarSix(x, y);
            do
            {
                labSix.nextIteration();
                Console.WriteLine("Текущиее значение для итерации" + labSix.getCurrentIterationNumber() + ":" + labSix.getCurrentIterationValue() + "\n Выйти из программы? 1 - выйти / 2 - продолжить");
                exitCode = int.Parse(Console.ReadLine());
            } while (exitCode != 1);
            ////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }

    class LabSixVarSix
        {
            public LabSixVarSix(int _x, int _y)
            {
                x = _x;
                y = _y;
                n = 0;
                p = 0;
            }

            private double getTermValue(int termNumber) //Вычисляем слагаемое, где termNumber - номер слагаемого
            {
                double involutedX = Math.Pow(x, 2 * termNumber - 1);
                double involutedY = Math.Pow(y, termNumber);
                double numerator = 0;
                if(termNumber % 2 == 0)
                    numerator = involutedX * Math.Cos(involutedY); // РАДИАНЫ! Math.PI * 180 для градусов
                else
                    numerator = - involutedX * Math.Sin(involutedY); // РАДИАНЫ! 
            double denomerator = (2 * termNumber - 1) * (2 * termNumber);
                double result = numerator/denomerator;
                return result;
            }

            public int getCurrentIterationNumber()
            {
                return n;
            }

            public double getCurrentIterationValue()
            {
                return p;
            }

            public void nextIteration()
            {
                n++;
                p += getTermValue(n);
            }

            private int x;
            private int y;
            private int n; //Текущий номер итерации
            private double p; //Результат работы на текущей итерации
        }
}