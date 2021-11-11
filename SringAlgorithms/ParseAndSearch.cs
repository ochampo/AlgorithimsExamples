using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SringAlgorithms
{
    public class ParseAndSearch
    {

        public void searchAlgorithm(string s)
        {
            Console.WriteLine("Hello World".ToLower().Contains("ll"));


            foreach (char c in s)
            {
                Console.WriteLine(c);
            }

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                Console.WriteLine(c);
            }

        }



        public Boolean IsAtEvenIndex(String s, char item)
        {

            if (String.IsNullOrEmpty(s))
            {
                return false;
            }
            for (int i = 0; i < s.Length / 2 + 1; i = i + 2)
            {
                if (s[i] == item)
                {
                    return true;
                }

            }

            return false;

        }




    }
}
