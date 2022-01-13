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

        public static bool FloydCycleDetection<T>(LinkedList<T> list)
        {
            var tortoise = list.First;
            var hare = list.First;

            while (tortoise != null && hare != null)
            {
                if (tortoise == hare)
                {
                    return true;
                }
                if (hare.Next != null)
                {
                    hare = hare.Next.Next;
                }
                tortoise = tortoise.Next;
            }
            return false;
        }


        public static bool HasCycle<T>(LinkedList<T> list)
        {

            if (list.First == null)
                return false;

            var slow = list.First;
            var fast = list.First;

            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;

                if (slow == fast)
                    return true;
            }

            return false;
        }




    }
}