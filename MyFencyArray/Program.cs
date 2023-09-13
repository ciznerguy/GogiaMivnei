using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyFencyArray
{
    public class Program
    {
        static void Main(string[] args)
        {
     

             


            FencyArr myFancy1 = new FencyArr(100,"guy");
             FencyArr myFancy2 = new FencyArr(100, "Afik");
             myFancy1.InitRandom(0, 2001);
             Thread.Sleep(2000);
             myFancy2.InitRandom(0, 2001);

            double avg1, avg2;

            avg1 = (double)myFancy1.SumTriple() / myFancy1.GreaterTriples(99);
            avg2 = (double)myFancy2.SumTriple() / myFancy2.GreaterTriples(99);
            Console.WriteLine( $"avg 1 {avg1} and avg2 {avg2}" );

            Console.WriteLine( $"max value {Math.Max(avg1,avg2)}" );







        }
    }
}
