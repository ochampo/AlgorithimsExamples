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




    }
}
