using HW8_C_Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_C_Sharp
{
    internal class Violin : MusicalInstrument
    {
        public Violin()
        {
            Description = "Violin";
        }
        public override void Sound()
        {
            Console.WriteLine("The violin makes a beautiful sound.\n");
        }
        public override void Show()
        {
            Console.WriteLine($"A {Description}");
        }
    }
}
