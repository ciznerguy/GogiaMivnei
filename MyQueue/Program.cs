using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQueue
{
    internal class Program
    {

        public static bool IsInQueue(Queue<int> myQueue,int num)
        {
            Queue<int> temp = new Queue<int>();
            bool isFound = false;

            while (!myQueue.IsEmpty())
            {
               if (myQueue.Head()==num)
                {
                    isFound = true;
                }
                temp.Insert(myQueue.Remove());

            }
            while (!temp.IsEmpty())
            {
                myQueue.Insert(temp.Remove());
            }
            return isFound;

        }

        public static int CountQueue (Queue<int> myQueue)
        {

            int count = 0;
            Queue<int> temp = Clone(myQueue);
            while (!temp.IsEmpty())
                    { 
                    temp.Remove();
                    count++;
                     }
         
            return count;


        }
        public static Queue<int> Clone(Queue<int> q)
        {
            Queue<int> temp = new Queue<int>();
            Queue<int> temp1 = new Queue<int>();
            while (!q.IsEmpty())
            {
                temp.Insert(q.Head());
                temp1.Insert(q.Remove());
            }
            while (!temp1.IsEmpty())
            {
                q.Insert(temp1.Remove());
            }
            return temp;
        }
        /*
        public static Queue<int> ReverseQueue(Queue<int> myQueue)
        {
            // Stage 1: Check if the queue is empty or has only one element
            if (myQueue.IsEmpty() || CountQueue(myQueue) == 1)
            {
                // The queue is already reversed or doesn't need to be reversed
                return myQueue;
            }

            // Stage 2: Reverse the order of elements in the queue
            int queueSize = CountQueue(myQueue);
            for (int i = 0; i < queueSize / 2; i++)
            {
                // Swap elements at positions i and queueSize - 1 - i
                int temp = myQueue.Remove();
                myQueue.InsertAtPosition(queueSize - 1 - i, temp);
            }

            return myQueue;
        }
        */
        public static Queue<int> CloneQueue (Queue<int> myQueue)
        {
            
            Queue<int> temp1 = new Queue<int>();
            Queue<int> temp2 = new Queue<int>();

            while (!myQueue.IsEmpty())
            {
                temp1.Insert(myQueue.Head());
                temp2.Insert(myQueue.Remove());

            }
           while (!temp2.IsEmpty())
            {
                myQueue.Insert(temp2.Remove());
            }
            Console.WriteLine( temp1 );
            return temp1;

        }
        public static int CountQueue2(Queue<int> myQueue)
        {
            int count = 0;
            Queue<int> temp = CloneQueue(myQueue);
            while (!temp.IsEmpty())
            {
                count++;
                temp.Remove();
            }
     
            return count;
        }

        //פעולה בוליאנית מקבלת שני תורים ומחזירה
        // אמת אם הם זהים
        public static bool IsQueueIdentical (Queue<int> queue1, Queue<int> queue2)
        {
            if (CountQueue(queue1) != CountQueue(queue2))
            {
                return false;
            }
            Queue<int> temp1 = CloneQueue(queue1);
            Queue<int> temp2 = CloneQueue(queue2);

            while (!temp1.IsEmpty())
            {
                if (temp1.Remove()!=temp2.Remove())
                {
                    return false;
                }

            }
            return true;

        }
        static void Main(string[] args)
        {
            Queue<int> queue1 = new Queue<int>();

        

            queue1.Insert(45);
            queue1.Insert(50);
            queue1.Insert(89);
            queue1.Insert(78);

            Console.WriteLine(CountQueue2 (queue1));
            Console.WriteLine(  queue1);

            Queue <CovidTest> myQueue = new Queue<CovidTest>();









        }
    }
}
