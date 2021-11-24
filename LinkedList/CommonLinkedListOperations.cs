using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class CommonLinkedListOperations
    {
        public void StringLinkList()
        {
            LinkedList<string> list = new LinkedList<string>();

            list.AddLast("Daniel");
            list.AddLast("peter");
            list.AddLast("Laura");
            list.AddLast("martha");
            list.AddLast("Frank");
            list.AddLast("Floss");

            Console.WriteLine(list.Contains("polly"));
            Console.WriteLine(list.Count);
            list.RemoveFirst();


        }


    }
}
