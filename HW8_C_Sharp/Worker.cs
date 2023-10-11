using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_C_Sharp
{
    internal abstract class Worker
    {
        protected string Description { get; set; }
        public abstract void Print();
    }
}
