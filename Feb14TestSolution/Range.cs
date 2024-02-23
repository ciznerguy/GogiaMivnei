using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb14TestSolution
{
    // add two value to this class low and high with classic style get and set - integers
    // add a method to check if a number is in the range


    public class Range
    {
        private int low;
        private int high;

       //add old style get and set
       public Range(int low, int high)
        {
            this.low = low;
            this.high = high;
        }
        public int GetLow()
        {
            return low;
        }
        public void SetLow(int low)
        {
            this.low = low;
        }
        public int GetHigh()
        {
            return high;
        }
        public void SetHigh(int high)
        {
            this.high = high;
        }

        public bool IsInRange(int number)
        {
            return number >= low && number <= high;
        }
    }
}
