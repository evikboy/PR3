using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3
{
    class Program
    {
        static void Set(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("arr[{0}]: ", i);
                array[i] = double.Parse(Console.ReadLine());
            }
        }

        static void Analysis(double[] array, ref double average, ref double geometric)
        {
            geometric = 1;
            average = 0;
            int kolovo_poz = 0, kolovo_otrits = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    kolovo_poz++;
                    geometric *= array[i];
                }
            }
            if(kolovo_poz != 0)
            {
                geometric = Math.Pow(geometric, 1.0 / kolovo_poz);
                Console.WriteLine("Среднее геометрическое для положительных чисел: {0}", geometric);
            }
            else Console.WriteLine("В массиве нет положительных чисел, поэтому невозможно посчитать среднее геометрическое");

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    kolovo_otrits++;
                    average += array[i];
                }
               
            }
            if (kolovo_otrits != 0)
            {
                average = average / kolovo_otrits;
                Console.WriteLine("Среднее арифметическое для отрицательных чисел: {0}", average);
            }
            else Console.WriteLine("В массиве нет отрицательных чисел, поэтому невозможно посчитать среднее арифметическое");
        }

        static void Main(string[] args)
        {
            double[] array1, array2, array3;
            array1 = new double[5];
            array2 = new double[10];
            array3 = new double[7];

            double average1, average2, average3;
            average1 = average2 = average3 = 0;

            double geometric1, geometric2, geometric3;
            geometric1 = geometric2 = geometric3 = 1;
 
            Console.WriteLine("Задайте элементы для первого массива: ");
            Set(array1);
            Analysis(array1, ref average1, ref geometric1);
            Console.WriteLine();

            Console.WriteLine("Задайте элементы для второго массива: ");
            Set(array2);
            Analysis(array1, ref average2, ref geometric2);
            Console.WriteLine();

            Console.WriteLine("Задайте элементы для третьего массива: ");
            Set(array3);
            Analysis(array1, ref average3, ref geometric3);
            Console.WriteLine();
        }
    }
}
