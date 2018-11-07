using ClockLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockLibTest.Helpers
{
    public class LabWorker
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
            Console.WriteLine("Laboratory have finished measuring. Time is out");

        }
    }
}
