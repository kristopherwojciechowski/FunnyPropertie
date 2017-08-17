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

            int[] arr = new int[7]{ 14, 12, -7, -3, -5, 0, -1};

            int modul = Math.Abs(arr[0]);
            int x,y;
            int wynik = arr[0];
            int indeks = 0;
            //for (int mm = 0; mm < arr.Length; mm++)
            //{
            //    Console.WriteLine(arr[mm]);
            //}

            for (int i = 0; i < arr.Length-1; i++)
            {
                x = Math.Abs(arr[i]);
                y = Math.Abs(arr[i+1]);
                if (x>y)
                {
                    modul = y;
                    wynik = arr[i + 1];
                    indeks = i;
                }
                Console.WriteLine("roznica: {0};  wynik: {0};  indeks: {2}", modul, wynik, indeks);
            }

            //Console.WriteLine(DigPow.digPow(46288, 3));
            //Console.WriteLine(digPow(46288, 3));
            Console.ReadKey();
        }
    }
}
