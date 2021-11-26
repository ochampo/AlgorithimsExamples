using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LinkedList.CustomLinkedList;

namespace LinkedList
{

    public class DeleteTheKthNodeFromTheEndOfList
    {
        public Node? head;

      

        public int kThNodeDisplay()
        {
            Node current = head;
            int count = 0;
            while (current != null)
            {                
                current = current.next;
                count++;
            }


            return count;
        }



    }
}
