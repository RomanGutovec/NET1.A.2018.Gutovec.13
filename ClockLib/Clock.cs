using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClockLib
{
    /// <summary>
    /// Class which measure time (like a timer)
    /// </summary>
    public sealed class Clock
    {
        /// <summary>
        /// Represents opportunity to register and unregister on event 
        /// when time is over
        /// </summary>
        public event EventHandler<EventArgs> TimeIsOver = delegate { };

        /// <summary>
        /// Start calculate time
        /// </summary>
        /// <exception cref="ArgumentNullException">Thrown when input time is incorrect</exception>
        /// <param name="measureTimeMilliseconds">time to measure in milliseconds</param>
        public void StartTimer(int measureTimeMilliseconds)
        {
            if (measureTimeMilliseconds <= 0)
            {
                throw new ArgumentNullException("Time must be positive");
            }

            Thread.Sleep(measureTimeMilliseconds);
            OnTimeIsOver(this, EventArgs.Empty);
        }

        private void OnTimeIsOver(object sender, EventArgs e)
        {
            TimeIsOver(sender, e);
        }
    }
}
