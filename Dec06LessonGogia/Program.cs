using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Dec06LessonGogia
{
    internal class Program
    {
        public static Node<Domino> Doubles( Node<Domino> list)
        {

            Domino myDomino = new Domino(-1, -1); 
            Node<Domino> listToReturn = new Node<Domino> (myDomino);
            Node<Domino> current = listToReturn;

            while (list != null)
            {
              if (list.GetValue().GetLeft()==list.GetValue().GetRight()) 
                {
                      Domino addDomino = new Domino(list.GetValue());
                      Node<Domino> nodeToAdd = new Node<Domino> (addDomino);
                      current.SetNext(nodeToAdd);
                      current=current.GetNext();


                }
              list = list.GetNext();
            }
            return listToReturn.GetNext();


        }
        
        static void Main(string[] args)
        {
            Domino d1 = new Domino(1, 6);
            Domino d2 = new Domino(d1);
            d2.SetLeft(0);
            Console.WriteLine(d1.GetLeft());
        }
    }
}
