using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashBasedStructures
{
    public class DisplayFrequency
    {
        static void frequency(int[] arr)
        {
            Dictionary<int, int> freq = new Dictionary<int, int>();


            for (int i = 0; i < arr.Length; i++)
            {
                if (freq.ContainsKey(arr[i]))
                {
                    freq[arr[i]]++;
                }
                else
                {
                    freq[arr[i]] = 1;
                }


            }

            foreach (KeyValuePair<int,int> x in freq)
            {
                Console.WriteLine(x.Key + " " + x.Value);
            }
        }


    }





}
}
