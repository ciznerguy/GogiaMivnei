using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb23
{
    public class Program
    {
        
        public static int FindMaxInArray (int[] arr)
        {
            // חסר טיפול אם המערך ריק
            int max = arr[0];
            for (int i=1; i<arr.Length;i++)
            {
                if (arr[i]>max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        // חישוב סכום מערך
        public static int SumOfArray (int[] arr)

        {
            int sum = 0;
            for (int i=0;i<arr.Length;i++)
            {
                sum += arr[i];

            }
            return sum;
        }
        
        public static bool IsCurrupt (int[] arr)
        {
            // למצוא שני מקסימום
            // לסכום אותם
            // להשוות לסכום שאר האיברים
            int firstMax =FindMaxInArray(arr);
            int secondMax = Int32.MinValue;//  secondMax =  -2147483648

            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i]>secondMax && arr[i]!=firstMax)
                {
                    secondMax = arr[i];
                }
            }

            return firstMax + secondMax > (SumOfArray(arr) - firstMax - secondMax)*2;





        }

        public static Node<Card> InsertCard (Node<Card> lst, Card c)
        {
            Node<Card> cardToInsert = new Node<Card>(c);

            // אם הרשימה ריקה החזר רשימה עם הקלף שהתקבל
            // לחפש את הקלף המקסימאלי מאותו צבע
            // אם אין קלף מקס הוסף בראש הרשימה
            // אם יש הוסף במקום הנכון

            if (lst==null)
            {
                return cardToInsert;
            }

            Node<Card> current = lst;

            Node<Card> max = lst;

            while (current.HasNext())
            {
                if (current.GetNext().GetValue().GetColor()==c.GetColor() && 
                    current.GetNext().GetValue().GetDigit()> max.GetValue().GetDigit())
                {
                    max = current.GetNext();
                }
             
            }
            if (max ==lst)
            {
                cardToInsert.SetNext(lst);
                return cardToInsert;
            }

                    current = lst;

                        while (current.GetNext() != max)

                        {
                            current = current.GetNext();
                        }
              
                        cardToInsert.SetNext(current.GetNext());
                        current.SetNext(cardToInsert);

                    return lst;


            }


        
        static void Main(string[] args)
        {
            //Generate list of cards

            Node<Card> lst = new Node<Card>(new Card(1, 'R'));
            Node<Card> head = lst;
            lst.SetNext(new Node<Card>(new Card(2, 'B')));
            lst.GetNext().SetNext(new Node<Card>(new Card(9, 'R')));
            Console.WriteLine(lst);
            Node<Card> toAdd = new Node<Card>(new Card(3, 'R'));
            Console.WriteLine(lst);

        }
    }
}
