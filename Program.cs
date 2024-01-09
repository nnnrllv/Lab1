using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel.DataAnnotations;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Часть 1: ");
            Console.WriteLine("Введите размер массива: ");
            int size = int.Parse(Console.ReadLine());
            var firstPart = new FirstPart(size);
            Console.WriteLine("Исходный массив:");
            PrintVector(firstPart.Vector);
            Console.WriteLine("Сумма положительных элементов: " + firstPart.GetSumOfPositiveElements());
            Console.WriteLine("Произведение между Min & Max по модулю: " + firstPart.GetMultiplicationBetweenAbsoluteMinMax());
            firstPart.SortByDescending();
            Console.WriteLine("После сортировки по убыванию:");
            PrintVector(firstPart.Vector);
           
            Console.WriteLine("Часть 2:");
            var secondPart = new SecondPart(4, 5);
            PrintMatrix(secondPart.Matrix);
          
            Console.WriteLine("Столбцов без нулей: " + secondPart.GetColsWithoutZerosCount());
            secondPart.GetCharacteristics();
            Console.WriteLine("После перестановки:");
            PrintMatrix(secondPart.Matrix);
        }
        static void PrintVector(IEnumerable<int> vector)
        {
            Console.WriteLine(string.Join(" ", vector));
        }
        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(" ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

    }
}