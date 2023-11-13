using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_demonstration
{
    public static class StringExtension
    {
        // метод Inverting - інвертування заданого рядка
        public static string Inverting(this string str)
        {
            string str_new = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                str_new += str[i];
            }

            return str_new;
        }

        // метод SymbolCount - підрахунок к-сті заданого символа у рядку
        public static int SymbolCount(this string str, char c)
        {
            int counter = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c)
                    counter++;
            }
            return counter;
        }
    }

}
