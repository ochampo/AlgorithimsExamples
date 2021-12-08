using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueuesAndStacks
{
    public class CheckForOpenParentheses
    {

        public Boolean Checker(string s)
        {
            Stack<char> stack = new Stack<char>();


            for (int i = 0; i < s.Length; i++)
            {
                char current = s[i];
                if (current == '(')
                {
                    stack.Push(current);
                    continue;

                }
                if (current == ')')
                {

                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }

                }



            }
            return stack.Count == 0;
        }

        public Boolean CheckerWithInt(string s)
        {
            int macthChecker = 0;


            for (int i = 0; i < s.Length; i++)
            {
                char current = s[i];
                if (current == '(')
                {
                    macthChecker++;
                    continue;

                }
                if (current == ')')
                {
                    if (macthChecker > 0)
                    {

                        macthChecker--;

                    }
                    else
                    {
                        return false;
                    }
                }
                



            }
            return macthChecker == 0;
        }





    }

}