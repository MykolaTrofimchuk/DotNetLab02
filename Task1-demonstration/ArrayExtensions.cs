using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_demonstration
{
    public static class ArrayExtensions
    {
        public static int CountOccurrences<T>(this T[] array, T value)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (EqualityComparer<T>.Default.Equals(array[i], value))
                {
                    count++;
                }
            }
            return count;
        }

        public static T[] UniqueArray<T>(this T[] array)
        {
            return array.Distinct().ToArray();
        }
    }
}
