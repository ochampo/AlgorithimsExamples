using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueuesAndStacks
{
    public class QueueTest
    {
        public void QueueImplementation()
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(52);
            queue.Enqueue(35);
            queue.Enqueue(44);
            

            int removedItem = queue.Dequeue();
            Console.WriteLine(removedItem);
            
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());
            int current;
            while(queue.TryDequeue(out current))
            {
                Console.WriteLine(current);
            }

        }





    }
}
