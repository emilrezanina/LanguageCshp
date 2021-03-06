﻿using System;
using Utils;

namespace Excersise02
{
    class Program
    {
        static void WorkWithStaticClass()
        {
            RandomNumberGenerator.GetClassName();
            for (int i = 0; i < 1000; i++)
            {
                System.Console.WriteLine(RandomNumberGenerator.Next());
            }
        }

        private static void WorkWithDataTypes()
        {
            int x = 3;
            int y = x;
            y += 2;
            x++;
            Console.WriteLine($"x: {x}; y: {y}");

            //ComplexNumber number1 = new ComplexNumber(1, 2);
            ComplexNumber number1 = new ComplexNumber() { First = 1, Second = 2 };
            //ComplexNumber number2 = number1;
            ComplexNumber number2 = new ComplexNumber(number1);
            number2.First += 2;
            number1.Second++;
            Console.WriteLine(number1);
            Console.WriteLine(number2);
        }

        private static int GetMagicWand(string text)
        {
            if (text.Length == 0)
                return -1;
            return text.Length;
        }

        private static void WorkWithNullableTypes()
        {
            int number1 = 3;
            int? number2 = null;
            ComplexNumber number3 = null;
            if (number2.HasValue)
            {
                int number4 = number2.Value;
            }
            number3?.Third.GetType();
            ComplexNumber number5 = new ComplexNumber(1, 2, null);
            number5?.Third?.GetType();
        }

        private static bool TryParse(string text, out int result)
        {
            int magicWand = text.Length == 0 ? -1 : text.Length;
            int magicWand2 = GetMagicWand(text);

            bool isConverted = int.TryParse(text, out result);
            return isConverted;
        }


        static void Main(string[] args)
        {
            //WorkWithStaticClass();
            WorkWithDataTypes();
            WorkWithNullableTypes();
            int a = 2;
            var b = a;

            int[,] array01 = new int[2,3];
            int[][] array02 = new int[2][];
            var JAHODA = array02[0];
            array02[0] = new int[4];
            array02[1] = new int[2];
        }

    }
}
