using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb23
{
    public class Card
    {
        private int digit;
        private char color;
       // generate constructor
       public Card(int digit, char color)
        {
            this.digit = digit;
            this.color = color;
        }
        // generate getters and setters
        public int GetDigit()
        {
            return digit;
        }
        public void SetDigit(int digit)
        {
            this.digit = digit;
        }
        public char GetColor()
        {
            return color;
        }
        public void SetColor(char color)
        {
            this.color = color;
        }
        // generate toString
        public override string ToString()
        {
            return "Card{" +
                    "digit=" + digit +
                    ", color=" + color +
                    '}';
        }
    }
}
