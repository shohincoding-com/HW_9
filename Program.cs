 
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
            Console.WriteLine("\nВсе элементы всех массивов!");

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
            Console.Write("\n");


            Console.WriteLine($"Удаленный элемент массив - StrArr: {ArrayHelper.Pop(ref StrArr)}");
            Console.WriteLine($"Удаленный элемент массив - IntArr: {ArrayHelper.Pop(ref IntArr)}");
            Console.WriteLine($"Удаленный элемент массив - DblArr: {ArrayHelper.Pop(ref DblArr)}");
            Console.WriteLine($"Удаленный элемент массив - DecArr: {ArrayHelper.Pop(ref DecArr)}");
            Console.WriteLine($"Удаленный элемент массив - FloArr: {ArrayHelper.Pop(ref FloArr)}");


            Console.Write("\n");


            Console.WriteLine($"Длина массив - StrArr после добавления элемент с конца массива: {ArrayHelper.Push(ref StrArr, "Six")}");
            Console.WriteLine($"Длина массив - IntArr после добавления элемент с конца массива: {ArrayHelper.Push(ref IntArr,    60)}");
            Console.WriteLine($"Длина массив - DblArr после добавления элемент с конца массива: {ArrayHelper.Push(ref DblArr,   6.5)}");
            Console.WriteLine($"Длина массив - DecArr после добавления элемент с конца массива: {ArrayHelper.Push(ref DecArr,  6.5m)}");
            Console.WriteLine($"Длина массив - FloArr после добавления элемент с конца массива: {ArrayHelper.Push(ref FloArr,  6.5f)}");


            Console.Write("\n");


            Console.WriteLine($"Удаленный элемент массива - StrArr: {ArrayHelper.Shift(ref StrArr)}");
            Console.WriteLine($"Удаленный элемент массива - IntArr: {ArrayHelper.Shift(ref IntArr)}");
            Console.WriteLine($"Удаленный элемент массива - DblArr: {ArrayHelper.Shift(ref DblArr)}");
            Console.WriteLine($"Удаленный элемент массива - DecArr: {ArrayHelper.Shift(ref DecArr)}");
            Console.WriteLine($"Удаленный элемент массива - FloArr: {ArrayHelper.Shift(ref FloArr)}");

            Console.Write("\n");

            Console.WriteLine($"Длина массив - StrArr после добавления один элемент в начало: {ArrayHelper.UnShift(ref StrArr, "Zero")}");
            Console.WriteLine($"Длина массив - IntArr после добавления один элемент в начало: {ArrayHelper.UnShift(ref IntArr,     00)}");
            Console.WriteLine($"Длина массив - DblArr после добавления один элемент в начало: {ArrayHelper.UnShift(ref DblArr,    0.5)}");
            Console.WriteLine($"Длина массив - DecArr после добавления один элемент в начало: {ArrayHelper.UnShift(ref DecArr,   0.5m)}");
            Console.WriteLine($"Длина массив - FloArr после добавления один элемент в начало: {ArrayHelper.UnShift(ref FloArr,   0.5f)}");



        }
    }
    static class ArrayHelper
    {

        ////Метод Pop()
        public static string Pop(ref string[] arrey)
            {
                int Rem_Ind_El = arrey.Length - 1;
                string Rem_El = arrey[Rem_Ind_El];
                arrey = arrey.Where((Item, Index) => Index != Rem_Ind_El).ToArray();
                return Rem_El;
            }

        public static int Pop(ref int[] arrey)
            {
                int Rem_Ind_El = arrey.Length - 1;
                int Rem_El = arrey[Rem_Ind_El];
                arrey = arrey.Where((Item, Index) => Index != Rem_Ind_El).ToArray();
                return Rem_El;
            }

        public static double Pop(ref double[] arrey)
            {
                int Rem_Ind_El = arrey.Length - 1;
                double Rem_El = arrey[Rem_Ind_El];
                arrey = arrey.Where((Item, Index) => Index != Rem_Ind_El). ToArray();
                return Rem_El;
            }

        public static decimal Pop(ref decimal[] arrey)
            {
                int Rem_Ind_El = arrey.Length - 1;
                decimal Rem_El = arrey[Rem_Ind_El];
                arrey = arrey.Where((Item, Index) => Index != Rem_Ind_El). ToArray();
                return Rem_El;
            }

        public static float Pop(ref float[] arrey)
            {
                int Rem_Ind_El = arrey.Length - 1;
                float Rem_El = arrey[Rem_Ind_El];
                arrey = arrey.Where((Item, Index) => Index != Rem_Ind_El). ToArray();
                return Rem_El;
            }

        //Метод Push()
        public static int Push(ref string[] arrey, string New_El)
        {
            arrey = arrey.Concat(new string[] { New_El }).ToArray();
            int LengthArr = arrey.Length;
            return LengthArr;
        }

        public static int Push(ref int[] arrey, int New_El)
        {
            arrey = arrey.Concat(new int[] { New_El }).ToArray();
            int LengthArr = arrey.Length;
            return LengthArr;
        }

        public static int Push(ref double[] arrey, double New_El)
        {
            arrey = arrey.Concat(new double[] { New_El }).ToArray();
            int LengthArr = arrey.Length;
            return LengthArr;
        }

        public static int Push(ref decimal[] arrey, decimal New_El)
        {
            arrey = arrey.Concat(new decimal[] { New_El }).ToArray();
            int LengthArr = arrey.Length;
            return LengthArr;
        }

        public static int Push(ref float[] arrey, float New_El)
        {
            arrey = arrey.Concat(new float[] { New_El }).ToArray();
            int LengthArr = arrey.Length;
            return LengthArr;
        }

        //Метод Shift()
        public static string Shift(ref string[] arrey)
        {
            string Rem_Fir_El = arrey[0];
            arrey = arrey.Where((item, index) => index != 0).ToArray();
            return Rem_Fir_El;
        }

        public static int Shift(ref int[] arrey)
        {
            int Rem_Fir_El = arrey[0];
            arrey = arrey.Where((item, index) => index != 0).ToArray();
            return Rem_Fir_El;
        }

        public static double Shift(ref double[] arrey)
        {
            double Rem_Fir_El = arrey[0];
            arrey = arrey.Where((item, index) => index != 0).ToArray();
            return Rem_Fir_El;
        }

        public static decimal Shift(ref decimal[] arrey)
        {
            decimal Rem_Fir_El = arrey[0];
            arrey = arrey.Where((item, index) => index != 0).ToArray();
            return Rem_Fir_El;
        }

        public static float Shift(ref float[] arrey)
        {
            float Rem_Fir_El = arrey[0];
            arrey = arrey.Where((item, index) => index != 0).ToArray();
            return Rem_Fir_El;
        }

        //Метод UnShift()
        public static int UnShift(ref string[] arrey, string New_El)
        {
            var NewArrey = new string[arrey.Length + 1];
            Array.Copy(arrey, 0, NewArrey, 1, arrey.Length);
            int LengthArr = NewArrey.Length;
            return LengthArr;
        }

        public static int UnShift(ref int[] arrey, int New_El)
        {
            var NewArrey = new int[arrey.Length + 1];
            Array.Copy(arrey, 0, NewArrey, 1, arrey.Length);
            int LengthArr = NewArrey.Length;
            return LengthArr;
        }

        public static int UnShift(ref double[] arrey, double New_El)
        {
            var NewArrey = new double[arrey.Length + 1];
            Array.Copy(arrey, 0, NewArrey, 1, arrey.Length);
            int LengthArr = NewArrey.Length;
            return LengthArr;
        }

        public static int UnShift(ref decimal[] arrey, decimal New_El)
        {
            var NewArrey = new decimal[arrey.Length + 1];
            Array.Copy(arrey, 0, NewArrey, 1, arrey.Length);
            int LengthArr = NewArrey.Length;
            return LengthArr;
        }

        public static int UnShift(ref float[] arrey, float New_El)
        {
            var NewArrey = new float[arrey.Length + 1];
            Array.Copy(arrey, 0, NewArrey, 1, arrey.Length);
            int LengthArr = NewArrey.Length;
            return LengthArr;
        }
        
    }
}
