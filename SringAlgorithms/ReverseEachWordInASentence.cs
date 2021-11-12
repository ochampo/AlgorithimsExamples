using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SringAlgorithms
{
    public class ReverseEachWordInASentence
    {

        public void ReversalSentence(string input)
        {

            

            String[] words = input.Split(' ');
            List<string> words2 = new List<string>();
            foreach (string word in words)
            {
                char[] chars = word.ToCharArray();
                Array.Reverse(chars);
                Console.Write(chars);
                Console.Write(' ');
            }
        }


        public string ReverseEachWord(String input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }
            ParseAndSearch parseAndSearch = new ParseAndSearch();
            StringBuilder result = new StringBuilder();
            string[] arr = input.Split(" ");
            for(int i = 0; i < arr.Length; i++)
            {
               result.Append((parseAndSearch.ReverseStringWithArray(arr[i])));

               if(i != arr.Length - 1)
                {
                    result.Append(" ");
                }
            
            }


            return result.ToString();

        }



    }
}
