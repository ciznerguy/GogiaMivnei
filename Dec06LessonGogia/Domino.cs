using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec06LessonGogia
{
    public class Domino
    {

        private int left; // 0-6
        private int right; // 0-6

        public Domino(int left, int right)
        {
            this.left = left;
            this.right = right;
        }
        // פעולה בונה מעתיקה
        public Domino (Domino other)
        {
            this.left = other.left;
            this.right = other.right;
        }

        public int GetLeft()
        {
            return left;
        }
        public int GetRight()
        {
            return left;
        }
        public void SetLeft(int left)
        {
            this.left = left;
        }
        public void SetRight(int right)
        {
            this.right = right;
        }
    }
}
