using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueuesAndStacks
{
    public class StackTest
    {

        public void ExperimentalStack()
        {
            Stack<string> stack = new Stack<string>();
            Console.WriteLine("Start Main");
            stack.Push("Main");
            Console.WriteLine("start ResponseBuilder");
            stack.Push("reportBuilder");
            Console.WriteLine("Start CallExternalService");
            stack.Push("CallExternalService");
            Console.WriteLine("End"+ stack.Pop());
            Console.WriteLine("parseExternalData");
            stack.Push("ParseExternalData");
            Console.WriteLine("ParseExternalData");
            Console.WriteLine("End " + stack.Pop());
            Console.WriteLine("End " + stack.Pop());
            Console.WriteLine("End " + stack.Pop());

            string item;

            Console.WriteLine(stack.TryPeek(out item));


        }



    }
}
