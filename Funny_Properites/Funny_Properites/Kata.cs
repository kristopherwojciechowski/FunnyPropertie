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
            }
            int min;
            if (Math.Abs(maxNegativValue) < Math.Abs(minPositivValue))
            {
                min = maxNegativValue;
            } else
            {
                min = minPositivValue;
            }
            if (Math.Abs(maxNegativValue) == Math.Abs(minPositivValue))
            {
                return null;
            }
            else 
            {
                return min;
            }
        }
    }
}
