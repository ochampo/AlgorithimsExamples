using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueuesAndStacks
{
    public class PrintNextGreaterElement
    {
        public void NumbersChecker(int [] arr)
        {

            if(arr.Length == 0)
            {
                Console.WriteLine();
                return;
            }

        Stack<int> stack = new Stack<int>();
        stack.Push(arr[0]);
            for (int i = 1; i < arr.Length; i++)
            {
                int next = arr[i];
                stack.Push(arr[i]);
                if (stack.Count > 0)
                {
                    int popped = stack.Pop();

                    while (popped < next)
                    {
                        Console.WriteLine(popped + "---->" + next );
                        popped = stack.Pop();
                     }
                }

                stack.Push(next);
            }
        
        
        
        
        
        }





    }
}
