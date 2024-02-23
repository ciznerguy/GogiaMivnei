using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagrutSummer2020
{
    internal class Program
    {
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
        public static bool IsExist (Queue<int> myQueue,int num)
        {
            Queue<int> copyQueue= Clone(myQueue);
            while (!copyQueue.IsEmpty()) 
            {
              if (copyQueue.Remove()%10==num)
                {
                    return true;
                }
            
            }


            return false;
        }

 

         

        public static int ReturnLeftDigit (int num)
        {
            while (num>9)
            {
                num /= 10;
            }

            return num;
        }

        public static bool AllExist(Queue<int> myQueue)
        {

            Queue<int> copyQueue = Clone(myQueue);
            Queue<int> temp = Clone(copyQueue);
            Console.WriteLine(  temp);
            int num, dig;
            while (!copyQueue.IsEmpty())
            {
              
                 num = copyQueue.Remove();
                dig = ReturnLeftDigit(num);
               
                Console.WriteLine($" {num} {dig}");
                Console.WriteLine(  temp);
                if (!IsExist(temp, dig))
                {
                    Console.WriteLine($"in false {num} {dig}");
                    return false;

                }
            }
            return true;
        }


        public static int ToNumber (Queue<int> q)
        {
            int num=0;

            int mul = 1;
            while (!q.IsEmpty())
            {
                num += q.Remove() * mul;
                mul *= 10;
            }
            return num;

      
        }

        public static int BigNumber (Node<Queue<int>> lst)

        {
            Node<Queue<int>> temp = lst;
            // int max =0;
            int max = ToNumber(lst.GetValue());
            if (temp.HasNext())
            {
                temp = temp.GetNext();
            }
            while (temp != null) 
            {
                // int current = ToNumber(temp.GetValue()
                // if (max < current)
                // max = current;
                max = Math.Max(max,ToNumber(temp.GetValue()));
                temp = temp.GetNext();
            }
            return max;
        }
        
        static void Main(string[] args)
        {
            Queue<int> queue1 = new Queue<int>();
            Console.WriteLine("dhi");


            queue1.Insert(54525);
            queue1.Insert(5048);
            queue1.Insert(899);
            queue1.Insert(978);
            Console.ReadLine();
     
          
         Console.WriteLine( AllExist(queue1 ));
        }
    }
}
