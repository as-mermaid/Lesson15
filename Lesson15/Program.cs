using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arith = new ArithProgression();
            Console.WriteLine("Введите шаг арифметической прогресии");
            arith.SetStep(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Введите начальное значение арифметической прогресии");
            arith.SetStart(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Введите количество шагов арифметической прогресии");
            int arithNum = Convert.ToInt32(Console.ReadLine());

            //Шагаем несколько раз для проверки
            for (int i = 0; i < arithNum; i++) 
                {
                    Console.WriteLine($"Шаг {i + 1} - {arith.GetNext()}");
                }

            //Сброс стартового значения
            arith.Reset();
            //Новый шаг и количество
            Console.WriteLine("Введите шаг арифметической прогресии");
            arith.SetStep(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Введите количество шагов арифметической прогресии");
            arithNum = Convert.ToInt32(Console.ReadLine());

            //Шагаем несколько раз для проверки
            for (int i = 0; i < arithNum; i++)
            {
                Console.WriteLine($"Шаг {i+1} - {arith.GetNext()}");
            }

            Console.ReadKey();

            // ГЕОМЕТРИЧЕСКАЯ ПРОГРЕССИЯ

            GeomProgression geom = new GeomProgression();
            Console.WriteLine("Введите шаг геометрической прогресии");
            geom.SetStep(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Введите начальное значение геометрической прогресии");
            geom.SetStart(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Введите количество шагов геометрической прогресии");
            int geomNum = Convert.ToInt32(Console.ReadLine());

            //Шагаем несколько раз для проверки
            for (int i = 0; i < geomNum; i++)
            {
                Console.WriteLine($"Шаг {i+1} - {geom.GetNext()}");
            }

            //Сброс стартового значения
            geom.Reset();
            //Новый шаг и количество
            Console.WriteLine("Введите шаг геометрической прогресии");
            geom.SetStep(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Введите количество шагов геометрической прогресии");
            geomNum = Convert.ToInt32(Console.ReadLine());

            //Шагаем несколько раз для проверки
            for (int i = 0; i < geomNum; i++)
            {
                Console.WriteLine($"Шаг {i + 1} - {geom.GetNext()}");
            }

            Console.ReadKey();

        }
    }
}
