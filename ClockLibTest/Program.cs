using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClockLib;
using ClockLibTest.Helpers;

namespace ClockLibTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock timer = new Clock();
            Trainer trainer = new Trainer();
            LabWorker labWorker = new LabWorker();
            trainer.Register(timer);
            labWorker.Register(timer);
            Console.WriteLine("Time to measure: 5 seconds... Start!");
            timer.StartTimer(5000);

            Console.ReadLine();
        }
    }
}
