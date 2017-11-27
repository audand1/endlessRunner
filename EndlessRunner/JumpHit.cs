using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessRunner
{
    class JumpHit : DoubleAction
    {
        public override void action1()
        {
            Jump jump = new Jump();
            jump.doAction();
        }
        public override void action2()
        {
            Hit hit = new Hit();
            hit.doAction();
        }
    }
}
