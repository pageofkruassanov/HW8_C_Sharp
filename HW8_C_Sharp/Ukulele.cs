using HW8_C_Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_C_Sharp
{
    internal class Ukulele : MusicalInstrument
    {
        public Ukulele()
        {
            Description = "Ukulele";
        }
        public override void Sound()
        {
            Console.WriteLine("Ukulele guitar sound.\n");
        }

        public override void Show()
        {
            Console.WriteLine($"A {Description}");
        }
    }
}
