﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApps
{
    class Program
    {
        static void Main(string[] args)
        {
            MinFunctions();
        }

        private static void MinFunctions()
        {
            /*Минимум функции
             * 
             * Эта задача потребует знания конструкции if-else. Если вы с ней знакомы из других языков программирования, это не составит проблем.
             * Если не знакомы совсем, то лучше пропустить эту задачу и сначала пройти следующий модуль.
             * Реализуйте метод GetMinX для нахождения такого числа xx, при котором кривая, заданная уравнением y(x) = ax^2 + bx + c, принимает минимальное значение.
             * Метод должен принимать неотрицательный коэффициент a, а также произвольные коэффициенты b и c,
             * и если решение существует, возвращать строковое представление искомого x, а иначе — строку Impossible.
             * 
             * 
             * 
             */
            Console.WriteLine(GetMinX(1, 2, 3));
            Console.WriteLine(GetMinX(0, 3, 2));
            Console.WriteLine(GetMinX(1, -2, -3));
            Console.WriteLine(GetMinX(5, 2, 1));
            Console.WriteLine(GetMinX(4, 3, 2));
            Console.WriteLine(GetMinX(0, 4, 5));

            // А в этих случаях решение существует:
            Console.WriteLine(GetMinX(0, 0, 2) != "Impossible");
            Console.WriteLine(GetMinX(0, 0, 0) != "Impossible");
        }

        private static string GetMinX(int a, int b, int c)
        {
            if (a < 0)
                return "Impossible";
            else if (a == 0)
                if (b == 0)
                    return c.ToString();
                else
                    return "Impossible";
            else
                    return (-((double)b / (2 * a))).ToString();
        }
    }
}
