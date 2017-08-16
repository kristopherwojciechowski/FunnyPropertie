using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funny_Properites
{
    class Program
    {
        static void Main(string[] args)
        {
            //DigPow.digPow(2, 2);
            Console.WriteLine("podaj liczbe:");
            String positivIntegerN = Console.ReadLine();
            //String k = positivIntegerN.Substring(0, 1);
            //Console.WriteLine("Substring: {0}", k);
            int p = 1;
            int tempNum, k;
            double sum = 0;
            for (int m = 1; m < positivIntegerN.Length; m++)
            {
                tempNum = Int32.Parse(positivIntegerN.Substring(m-1, m));
                Console.WriteLine("selected number: {0}", tempNum);
                sum = sum + Math.Pow(Convert.ToDouble(tempNum),Convert.ToDouble(p+m-1));
                Console.WriteLine("suma po {0}-tej iteracji: {1}", m, sum);
            }
            Console.WriteLine("ilosc znakow w liczbie: {0}", positivIntegerN.Length);
            Console.WriteLine("suma: {0}", sum);
        }
    }
}
