using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashBasedStructures
{
    public class NodeTest
    {
        public int data;
        public  NodeTest next;

        public NodeTest(int i)
        {
            data = i;
            next = null;
        }


        public void print()
        {
            Console.WriteLine("|" + data + "-> ");
            if(next != null)
            {
                next.print();
            }
        }

        public void AddToEnd(int data)
        { 
            if(next == null)
            {
                next = new NodeTest(data);
            }
            else
            {
                next.AddToEnd(data);
            }
            
            
        }



    }
}
