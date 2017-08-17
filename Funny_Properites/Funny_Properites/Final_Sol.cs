//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Funny_Properites
//{
//    class Program1
//    {
//        public static MojeMetoda()
//        {
//            Console.WriteLine("podaj minimalna liczbe:");
//            String positivIntegerMin = Console.ReadLine();

//            Console.WriteLine("podaj maksymalna liczbe:");
//            String positivIntegerMax = Console.ReadLine();

//            int p, tempNum, h;
//            for (h = Int32.Parse(positivIntegerMin); h <= Int32.Parse(positivIntegerMax); h++)
//            {
//                String positivInteger = h.ToString();
//                for (p = 0; p <= 11; p++)
//                {
//                    double sum = 0;
//                    for (int m = 1; m <= positivInteger.Length; m++)
//                    {
//                        tempNum = Int32.Parse(positivInteger.Substring(m - 1, 1));
//                        //Console.WriteLine("selected number: {0}", tempNum);
//                        //Console.WriteLine("{0} ^ {1} = {2}", tempNum, p + m - 1, Math.Pow(Convert.ToDouble(tempNum), Convert.ToDouble(p + m - 1)));
//                        sum = sum + Math.Pow(Convert.ToDouble(tempNum), Convert.ToDouble(p + m - 1));
//                        //Console.WriteLine("suma po {0}-tej iteracji: {1}", m, sum);
//                    }
//                    double resztaZDzielenie = sum % double.Parse(positivInteger);
//                    //Console.WriteLine("reszta z dzielenie wynosi: {0}", resztaZDzielenie);

//                    if (resztaZDzielenie == 0)
//                    {
//                        Console.WriteLine();
//                        Console.WriteLine("liczba: {0}", h);
//                        Console.WriteLine("p poczatkowe = {0}", p);
//                        Console.WriteLine("czynik skalujacy wynosi: {0}", sum / double.Parse(positivInteger));
//                    }
//                }
//            }
//            Console.ReadKey();
//        }
//    }
//}
