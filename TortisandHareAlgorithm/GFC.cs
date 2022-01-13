using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TortisandHareAlgorithm.LinkedList;

namespace TortisandHareAlgorithm
{
    public class GFC
    {


        public static void push(int new_data)
        {

            // Allocate node
            LinkedList linkedList = new LinkedList();
            Node new_node = new Node(new_data);

            // Put in the data
            new_node.next = linkedList.head;
            linkedList.head = new_node;
        }
        //public static bool detectLoop(Node h)
        //{
        //    Node slow_p = LinkedList.head, fast_p = head;
        //    while (slow_p != null && fast_p != null
        //           && fast_p.next != null)
        //    {
        //        slow_p = slow_p.next;
        //        fast_p = fast_p.next.next;
        //        if (slow_p == fast_p)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;

        //}



    }
}
