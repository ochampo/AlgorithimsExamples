using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class CustomLinkedList
    {
      public  Node? head;

        public class Node
        {

            public int data;

            public Node next; 


            public Node(int d ) 
            { 
                data = d; 
            }
        }
        public void deleteBackHalf()
        {
            if(head==null || head.next == null )
            {
                head = null;
            }
            Node slow = head;
            Node fast = head;
            Node prev = null;
            
            while(fast != null && slow.next != null )
            {
                prev = slow;
                slow = slow.next;
                fast = fast.next.next;
            
            }
            prev.next = null;
        }

        public void displayContents()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.data + "->");
                current = current.next;
            }

        }

        public int kThNodeDisplay()
        {
            Node current = head;
            int count = 0;
            while (current != null)
            {
                Console.Write(current.data + "->");
                current = current.next;
                count++;
            }


            return count;
        }

    }
}
