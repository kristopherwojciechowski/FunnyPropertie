using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funny_Properites
{
    public class DigPow
    {
        public static double digPow(int n, int p)
        {
            String positivIntegerN = n.ToString();
            int tempNum;
            double sum = 0;
            for (int m = 1; m <= positivIntegerN.Length; m++)
            {
                tempNum = Int32.Parse(positivIntegerN.Substring(m - 1, 1));
                sum = sum + Math.Pow(Convert.ToDouble(tempNum), Convert.ToDouble(p + m - 1));
            }
            double resztaZDzielenie = sum % double.Parse(positivIntegerN);

            if (resztaZDzielenie == 0)
            {
                return sum / double.Parse(positivIntegerN);
            }
            return -1;
        }

    }
}
