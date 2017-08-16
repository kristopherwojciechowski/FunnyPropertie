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
            DigPow.digPow(2, 2);
            Console.WriteLine("podajliczbe:");
            String positivIntegerN = Console.ReadLine();
            String k = positivIntegerN.Substring(0, 1);
            Console.WriteLine("Substring: {0}", k);
            Console.WriteLine("dlugosc: {0}", positivIntegerN.Length);
        }
    }
}
