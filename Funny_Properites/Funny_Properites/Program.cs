using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funny_Properites
{
    class Program
    {
        public static int[] intToIntArray(int num)
        {
            String number = num.ToString();
            int[] intArray = new int[number.Length];
            for (int k = 1; k<=number.Length; k++)
            {
                intArray[k-1] = Int32.Parse(number.Substring(k-1, 1));
            }
            return intArray;
        }

        public static double digPow(int n, int p)
        {
            int[] nToArray = intToIntArray(n);
            double sum = 0;
            for (int m = 0; m < nToArray.Length; m++)
            {
                sum = sum + Math.Pow(Convert.ToDouble(nToArray[m]), Convert.ToDouble(p));
            }
            double resztaZDzielenie = sum % n;

            if (resztaZDzielenie == 0)
            {
                return sum / n;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            /*
              This class performs an important function.
            */


            //Console.WriteLine("podaj minimalna liczbe:");
            //String positivIntegerMin = Console.ReadLine();

            //Console.WriteLine("podaj maksymalna liczbe:");
            //String positivIntegerMax = Console.ReadLine();

            //int p, tempNum, h;
            //for (h = Int32.Parse(positivIntegerMin); h <= Int32.Parse(positivIntegerMax); h++)
            //{
            //    String positivInteger = h.ToString();
            //    for (p = 0; p <= 11; p++)
            //    {
            //        double sum = 0;
            //        for (int m = 1; m <= positivInteger.Length; m++)
            //        {
            //            tempNum = Int32.Parse(positivInteger.Substring(m - 1, 1));
            //            sum = sum + Math.Pow(Convert.ToDouble(tempNum), Convert.ToDouble(p + m - 1));
            //        }
            //        double resztaZDzielenie = sum % double.Parse(positivInteger);

            //        if (resztaZDzielenie == 0)
            //        {
            //            Console.WriteLine();
            //            Console.WriteLine("liczba: {0}", h);
            //            Console.WriteLine("p poczatkowe = {0}", p);
            //            Console.WriteLine("czynik skalujacy wynosi: {0}", sum / double.Parse(positivInteger));
            //        }
            //    }
            //}

            //int[] arr = new int[7] { 14, 12, -7, -3, -5, 3, -2 };
            int[] arr = new int[6] { -5, 11, 11, 2, -1, 1 };

            Console.WriteLine("Array: ");
            for (int m = 0; m<arr.Length; m++)
            {
                Console.WriteLine("m = {0}, arr[{0}] = {1} ",m, arr[m]);
            }

            Console.WriteLine();

            int minPositivValue = arr[0];
            int maxNegativValue = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                {
                    if (Math.Abs(arr[i]) <= Math.Abs(minPositivValue))
                    {
                        minPositivValue = arr[i];
                    }
                }
                else
                {
                    if (Math.Abs(arr[i]) <= Math.Abs(maxNegativValue))
                    {
                        maxNegativValue = arr[i];
                    }
                }
                Console.WriteLine("roznica: {0}; ", minPositivValue);
                Console.WriteLine("Dla wartosci ujemnych:");
                Console.WriteLine("roznica: {0}; ", maxNegativValue);
                Console.WriteLine();
            }

            Console.WriteLine();

            int abs1 = Math.Abs(maxNegativValue);
            int abs2 = Math.Abs(minPositivValue);

            if (abs1 == abs2)
            {
                Console.WriteLine("jest wiecej niz jedno rozwiazania");
            }
            else if (abs1 < abs2)
            {
                Console.WriteLine("rozwizaniem jest: " + maxNegativValue);
            }
            else
            {
                Console.WriteLine("rozwizaniem jest: " + minPositivValue);
            }

            //Console.WriteLine(DigPow.digPow(46288, 3));
            //Console.WriteLine(digPow(46288, 3));
            Console.WriteLine();

            Console.WriteLine("klasa Kata; wynik: " + Kata.Closest(arr));
            Console.ReadKey();
        }
    }
}
