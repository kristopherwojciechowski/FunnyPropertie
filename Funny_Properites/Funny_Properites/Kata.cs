using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funny_Properites
{
    class Kata
    {
        public static int? Closest(int[] arr)
        {
            int roznica, wynik;
            for (int i=0; i<arr.Length; i++)
            {
                roznica = Math.Abs(arr[i]);
                wynik = arr[i];
                if( Math.Abs(arr[i+1]) < roznica)
                {
                    roznica = Math.Abs(arr[i + 1]);
                    wynik = arr[i+1];
                    return wynik;
                }
            }
            return null;
        }
    }
}
