 
using System;
using System.Linq;

namespace MyprojecsApp
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] StrArr =  { "One", "Two", "Three", "Four", "Five"};
            int[] IntArr =     { 10,     20,     30,     40,       50 };
            double[] DblArr =  { 1.5,    2.5,    3.5,    4.5,      5.5};
            Decimal[] DecArr = { 1.5m,   2.5m,   3.5m,   4.5m,    5.5m};
            float[] FloArr =   { 1.5f,   2.5f,   3.5f,   4.5f,    4.5f};

            // выводим на консол все элементы всех массивов!!
            Console.WriteLine("Все элементы всех массивов!");

            for (int i = 0; i < StrArr.Length; i++)
                {
                    Console.Write($"{StrArr[i]} ");
                }
            Console.Write("\n");
            for (int i = 0; i < IntArr.Length; i++)
                {
                    Console.Write($"{IntArr[i]}   ");
                }
            Console.Write("\n");
            for (int i = 0; i < DblArr.Length; i++)
                {
                    Console.Write($"{DblArr[i]}  ");
                }
            Console.Write("\n");
            for (int i = 0; i < DecArr.Length; i++)
                {
                    Console.Write($"{DecArr[i]}  ");
                }
            Console.Write("\n");
            for (int i = 0; i < FloArr.Length; i++)
                {
                    Console.Write($"{FloArr[i]}  ");
                }

        }
    }
    static class ArrayHelper
    {

        
    }
}
