using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3ForrBargut
{
    public class Airport
    {
        private Flight[] flights;

        public Airport(int n)
        {
            flights = new Flight[n];
        }

        public bool IsFly()
        {

            for (int i = 0; i < flights.Length; i++)
            {
                if (flights[i].GetName() == "sky")
                {
                    return true;
                }

            }
            return false;
        }
    }
}
