using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class Program
    {

        // יש לכתוב פעולה המקבלת מספר ומחזירה כמה ספרות יש לו
        // 1234   123

        public static int NumDigits (int num)
        {
            if (num<10)
            {
                return 1;
            }
            Console.WriteLine($"run method when num={num}");
            return NumDigits(num / 10) + 1;


        }
        static void Main(string[] args)
        {
            int num = 1234;
            int lengthOfNum=NumDigits(num);
            Console.WriteLine($" length of {num} is {lengthOfNum}");
        }
    }
}
