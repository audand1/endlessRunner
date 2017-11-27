using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessRunner
{
    class NightTime : State
    {
        public override void Handle(BackgroundContext context)
        {
            context.State = new DayTime();
        }
    }
}
