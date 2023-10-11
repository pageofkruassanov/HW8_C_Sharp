using HW8_C_Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_C_Sharp
{
    internal class Cello : MusicalInstrument
    {
        public Cello()
        {
            Description = "Cello";
        }
        public override void Sound()
        {
            Console.WriteLine("Deep sound of cello.\n");
        }

        public override void Show()
        {
            Console.WriteLine($"A {Description}");
        }
    }
}
