﻿using HW8_C_Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_C_Sharp
{
    internal class President : Worker
    {
        public President()
        {
            Description = "President";
        }
        public override void Print()
        {
            Console.WriteLine(Description);
        }
    }
}
