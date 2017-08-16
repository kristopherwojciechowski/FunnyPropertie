using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funny_Properites
{
    public class DigPow
    {
        public static long digPow(int n, int p)
        {
            String positivIntegerN = n.ToString();
            int tempNum, k;
            double sum = 0;
            for (int m=1; m<(positivIntegerN.Length - 1); m++)
            {
                tempNum = Int32.Parse(positivIntegerN.Substring(m - 1, m));
                sum = sum + Math.Pow(System.Convert.ToDouble(tempNum),
                    System.Convert.ToDouble(p));
            }
            int zwrot;
            zwrot = (int) sum / n;
            return -1;
        }

    }
}
