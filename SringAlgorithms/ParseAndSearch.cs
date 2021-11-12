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


        public string ReverseString(string input)
        {
            if (String.IsNullOrEmpty(input))
            {
                return input;
            }

            StringBuilder reversedStr = new StringBuilder(input.Length);

            for (int i = input.Length-1; i >= 0; i--)
            {
                reversedStr.Append(input[i]);
            }

            return reversedStr.ToString();

        }

        public string ReverseStringWithArray(string input)
        {
            if (String.IsNullOrEmpty(input))
            {
                return input;
            }

            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);

        }


    }
}
