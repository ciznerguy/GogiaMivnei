﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3ForrBargut
{
    public class Time
    {
        private int hour;
        private int minute;

        public Time()
        {

        }

        public Time (int hour, int minute)
        {
            this.hour = hour;
            this.minute = minute;

            if (this.minute<0 || this.minute>59)
            {
                this.minute = 0;
            }
            if (this.hour < 0 || this.hour > 23)
            {
                this.hour = 0;
            }

        }
    }
}
