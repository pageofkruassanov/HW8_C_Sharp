using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Task 3:
            MusicalInstrument instrument = new Trombone();
            instrument.Show();
            instrument.Sound();

            instrument = new Ukulele();
            instrument.Show();
            instrument.Sound();
            Console.ReadLine();

            //Task 4:
            Worker[] workers = new Worker[]
            {   
                new President(),
                new Manager(),
                new Security(),
                new Engineer(),
            };

            foreach (Worker worker in workers)
            {
                worker.Print();
            }
            Console.ReadLine();
        }
    }
}
