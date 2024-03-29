﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class SecondPart
    {
        private readonly int[,] matrix;

        public SecondPart(int rows, int cols)
        {
            if (rows < 0 || cols < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(rows) + " or " + nameof(cols));
            }

            matrix = new int[rows, cols];

            var random = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(-10, 10);
                }
            }
        }

        public int[,] Matrix
        {
            get
            {
                return matrix;
            }
        }
      
        public int GetColsWithoutZerosCount()
        {
            int counter = matrix.GetLength(0);

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i, j] == 0)
                    {
                        counter--;
                        break;
                    }
                }
            }

            return counter;
        }
        
        public void GetCharacteristics()
        {
            int length = matrix.GetLength(0);
            int[] characteristics = new int[length];

            for (int i = 0; i < length; i++)
            {
                int characteristic = 0;

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > 0 && matrix[i, j] % 2 == 0)
                    {
                        characteristic += matrix[i, j];
                    }
                }

                characteristics[i] = characteristic;
            }
            Array.Sort(characteristics);
            int[,] tempMatrix = new int[length, matrix.GetLength(1)];

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    tempMatrix[i, j] = matrix[Array.IndexOf(characteristics, characteristics[i]), j];
                }
            }
        }
    }
}
