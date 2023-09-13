using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*



 * */
namespace MyFencyArray
{
    public class FencyArr
    {

        private int[] myArr;
        private string name;

        public FencyArr(int n,string name)
        {
           this.myArr = new int[n];
           this.name = name;
            for (int i = 0; i < myArr.Length; i++) 
            {
                this.myArr[i] = 0;
            }
        }

        public void InitRandom ( int from, int to)
        {
            Random rnd = new Random();

            for (int i =0; i < myArr.Length;i++) 
            {
                this.myArr[i] = rnd.Next(from,to);
            }

        }

        public int[] GetArr()
        {
            return this.myArr;
        }

        public bool IsTriple (int index)
        {
            /*
           if (index<0 || index>=this.myArr.Length)
            {
                return false;
            }
            if (myArr[index]>99 && myArr[index]<1000)
            {
                return true;
            }
            return false;
            */

            return (index>=0 && index<this.myArr.Length && myArr[index]>99 && myArr[index]<1000);
        }

        public int SumTriple ()
        {
            int sum = 0;
            for (int i = 0;i < this.myArr.Length; ++i) 
              {
                // להוסיף הסבר
                if (this.IsTriple(i)==true)
                {
                    sum += myArr[i];
                }
              }
            return sum;
        }

        public int GreaterTriples ( int n)

        {
            int counter = 0;
            for (int i = 0; i < this.myArr.Length; ++i)

            {
                if (this.IsTriple(i) && myArr[i]>n )
                {
                    counter++;
                }
            }
            return counter;

        }
        public override string ToString()
        {
            return "guy";
        }
    }
}
