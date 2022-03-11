using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    public delegate void ClockHandler(Object sender);
    class Clock
    {
       public event ClockHandler onTick;
       public event ClockHandler onRing;
        
        public void Alarm(int hour, int min,int sec)
        {
            while(true)
            {
                TimeSpan Interval = TimeSpan.FromMilliseconds(1000);
                System.Threading.Thread.Sleep(Interval);
                if (DateTime.Now.Hour == hour && DateTime.Now.Minute == min && DateTime.Now.Second >= sec && DateTime.Now.Second <= sec + 5)
                {
                    onRing(this);
                }
                onTick(this);
            }
        }
    }
}
