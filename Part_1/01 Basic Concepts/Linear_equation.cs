using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Linear_Algebra_Csharp.Part_1
{
    internal class Linear_equation
    {
        private bool IsFloatValid(string value)
        {
            return float.TryParse(value, out _);
        }

        //----------------------------------------------------------------------------------
        public object Linear_eq()
        {
            Console.WriteLine("\n" + "y = m*x + b\n" + "I");
            char y1 = Console.ReadKey().KeyChar;
            if (y1 != 'x' && y1 != 'y')
            {
                Console.WriteLine("\nError: Enter only 'y' or 'x'.");
            }

            Console.WriteLine("\nEnter M");
            string m1 = Console.ReadLine();
            Console.WriteLine("Enter X");
            string x1 = Console.ReadLine();
            Console.WriteLine("Enter B");
            string b1 = Console.ReadLine();

            //Check if the entered values are numbers - Проверяем, являются ли введённые значения числами

            object m; // Используем object, чтобы хранить либо float, либо string
            object x;
            object b;

            if (IsFloatValid(m1))
            {
                m = float.Parse(m1); // Преобразуем в float
            }
            else
            {
                m = m1; // Оставляем строкой
            }

            if (IsFloatValid(x1))
            {
                x = float.Parse(x1); // Преобразуем в float
            }
            else
            {
                x = x1; // Оставляем строкой
            }

            if (IsFloatValid(b1))
            {
                b = float.Parse(b1); // Преобразуем в float
            }
            else
            {
                b = b1; // Оставляем строкой
            }

            object result; // Переменная для результата
            if (m is float mf && x is float xf)
            {
                if (b is float bf)
                {
                    result = mf * xf + bf;
                }
                else
                {
                    result = $"{mf} * {xf} + {b}"; // b - строка
                }
            }
            else
            {
                result = $"{m} * {x} + {b}"; // m или x - строка
            }
            return result;
        }
    }
}
