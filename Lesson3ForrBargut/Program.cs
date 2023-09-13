using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3ForrBargut
{
    internal class Program
    {

        public static int OneOrSeven(int[] arr)
            {
            int count1 = 0, count7 = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 1)
                {
                    count1++;
                }
                else
                {

                    count7++;
                }

               

            }
            // return 1 or return 7
            if (count1 > count7)
            {
                return 1;
            }
            return 7;



        }
    


        
        static void Main(string[] args)
        {
            int[] arr1 = { 1, -11, -1, 7, -1,-8,-8 };
            int[] arr2 = { 1, 7, 7, 7, 7, 7, 7 };











            int result1 = OneOrSeven(arr1);
            int result2 = OneOrSeven(arr2);

            Console.WriteLine($" arr1 contain more {result1}");
            Console.WriteLine($" arr2 contain more {result2}");
        }
    }
}
