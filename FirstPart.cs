using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class FirstPart
    {
        private readonly int[] array;

        public FirstPart(int length)
        {
            if (length <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(length));
            }

            var random = new Random();

            array = new int[length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-10, 10);
            }
        }
        public IReadOnlyList<int> Vector
        {
            get
            {
                return array;
            }
        }
        public int GetSumOfPositiveElements()
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    sum += array[i];
                }
            }

            return sum;
        }
        public int GetMultiplicationBetweenAbsoluteMinMax()
        {
            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) > Math.Abs(array[maxIndex]))
                {
                    maxIndex = i;
                }
            }

            int minIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) < Math.Abs(array[minIndex]))
                {
                    minIndex = i;
                }
            }
            if (maxIndex > minIndex)
            {
                int tmp = maxIndex;
                maxIndex = minIndex;
                minIndex = tmp;
            }

            int mul = 1;

            for (int i = maxIndex + 1; i < minIndex; i++)
            {
                mul *= array[i];
            }

            return mul;
        }
        public void SortByDescending()
        {
            Array.Sort(array);
            Array.Reverse(array);
        }

    }
}