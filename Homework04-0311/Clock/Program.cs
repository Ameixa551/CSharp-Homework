//使用事件机制，模拟实现一个闹钟功能。闹钟可以有嘀嗒（Tick）事件和响铃（Alarm）两个事件。在闹钟走时时或者响铃时，在控制台显示提示信息
using System;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            Plan plan1 = new Plan();
            plan1.clock.Alarm(plan1.Hour, plan1.Minute, plan1.Second);
        }
    }
}