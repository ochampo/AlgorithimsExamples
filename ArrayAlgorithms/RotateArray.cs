using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAlgorithms
{
    public class RotateArray
    {
        static void RotateArrayLeft (int [] input)
        {
            int[] reversed = new int[input.Length];
            int temp = input[0];
            for (int i = 0; i < input.Length; i++)
            {
                reversed[i] = input[input.Length - i - 1];

            }
            

        }



    }
}
