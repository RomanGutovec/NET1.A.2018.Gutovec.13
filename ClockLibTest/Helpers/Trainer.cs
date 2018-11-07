using ClockLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockLibTest.Helpers
{
    public class Trainer
    {
        public void Register(Clock timer)
        {
            timer.TimeIsOver += ShowMsg;
        }

        public void Unregister(Clock timer)
        {
            timer.TimeIsOver -= ShowMsg;
        }

        private void ShowMsg(object sender, EventArgs eventArgs)
        {
            Console.WriteLine("Trainer have finished measuring. Time is out");

        }
    }
}
