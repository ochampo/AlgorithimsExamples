using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAlgorithms
{
    public class aggregatingArrays
    {
        public int[] FindEvenNumbers(int[] arr1, int[] arr2)
        {
            ArrayList result = new ArrayList();
            foreach (int num in arr1)
            {
                if(num % 2 == 0)
                {
                    result.Add(num);
                }
            }
            foreach (int num in arr2)
            {
                if (num % 2 == 0)
                {
                    result.Add(num);
                }
            }

            return (int[])result.ToArray(typeof(int));

        }
    }


}

