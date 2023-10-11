using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_C_Sharp
{
    internal abstract class MusicalInstrument
    {
        protected string Description { get; set; }
        public abstract void Sound();
        public abstract void Show();
    }
}
