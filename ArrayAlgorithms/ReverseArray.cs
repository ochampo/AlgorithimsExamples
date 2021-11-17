using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAlgorithms
{
    public class ReverseArray
    {
        public int [] Reverse(int[] input)
        {
            int[] reversed = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                reversed[i] = input[input.Length-i-1];

            }
            return reversed;
        }

    }
}
