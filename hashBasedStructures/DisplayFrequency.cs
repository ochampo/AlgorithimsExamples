using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashBasedStructures
{
    public class DisplayFrequency
    {
      public  static void frequency(int[] arr)
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

            foreach (KeyValuePair<int, int> x in freq)
            {
                Console.WriteLine(x.Key + " ->" + x.Value);
            }
        }


        public static void testingDictionaries(int[] arr)
        {
            Dictionary<int, int> freq = new Dictionary<int, int>();


            for (int i = 0; i < arr.Length; i++)
            {
                freq[100] = 45;

                Console.WriteLine(" i " + i);
                if (freq.ContainsKey(arr[i]))
                {
                    Console.WriteLine(" arr[i] " + arr[i]);
                    Console.WriteLine(" arr[i]++ " + freq[arr[i]]++);
                    Console.WriteLine(freq[arr[i]]);
                   
                }
                else
                {
                    //Console.WriteLine(freq[arr[i]]);
                    freq[arr[i]] = 1;
                }


            }

            foreach (KeyValuePair<int, int> x in freq)
            {
                Console.WriteLine(x.Key + " ->" + x.Value);
            }
        }



    }





}

