using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb14TestSolution
{
    public class Program
    {


        public static int CalculateNumber(Node<int> lst)

        {
            int mul = 1;
            int num = 0;
            while (lst != null)
            {
                num = num * mul;
                num += lst.GetValue();
                lst = lst.GetNext();
                mul = mul * 10;
            }
            return num;

        }


        public static Node<int> NumToList(int num)
        {
            // 1234
            Node<int> head = new Node<int>(num % 10); // head >> 4
            num /= 10; // 123
            while (num != 0)
            {
                Node<int> nodeToAdd = new Node<int>(num % 10); // nodeToAdd >> 3 // nodeToAdd >> >>2 
                //nodeToAdd >>1
                nodeToAdd.SetNext(head); // nodeToAdd 2>> 3>>4  
                head = nodeToAdd;// head>>1>> 2>>3>>4
                num = num / 10; // 12 // 1  //0
            }
            return head;
        }

        public static Node<int> SumOf2Lists(Node<int> lst1, Node<int> lst2)
        {
            /*
            int num1 = CalculateNumber(lst1);
            int num2 = CalculateNumber(lst2);
            int sum = num1 + num2;
            return NumToList(sum);
            */
            return NumToList(CalculateNumber(lst1) + CalculateNumber(lst2));


        }

        public static bool IsIncluded(Node<int> lst1, Node<Range> lst2)

        {
            while (lst1 != null || lst2 != null)
            {

                if (lst1.GetValue() < lst2.GetValue().GetLow()
                    || lst1.GetValue() > lst2.GetValue().GetHigh())
                {
                    lst2 = lst2.GetNext();
                }
                else
                {
                    lst1 = lst1.GetNext();
                }

            }
            return lst2 != null;

        }

    }







    }

