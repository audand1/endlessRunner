using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessRunner
{
    class DayTime : State
    {
        public override void Handle(BackgroundContext context)
        {
            context.State = new NightTime();
        }
    }
}
