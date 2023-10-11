using HW8_C_Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_C_Sharp
{
    internal class Trombone : MusicalInstrument
    {
        public Trombone()
        {
            Description = "Trombone";
        }
        public override void Sound()
        {
            Console.WriteLine("High pitch of trombone sound.\n");
        }

        public override void Show()
        {
            Console.WriteLine($"A {Description}");
        }
    }
}
