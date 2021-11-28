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
        public void DeleteTheKthNodeFromTheEndOfList(int kth)
        {
            if(head==null || kth == 0 )
            {
                return;
            }
            Node first = head;
            Node second = head;
            
            for(int i = 0; i < kth;i++)
            {
                second = second.next;
                if(second.next == null)
                {
                    if(i==kth-1)
                    {
                        head = head.next;
                    }
                }

                return;


            }
            
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
