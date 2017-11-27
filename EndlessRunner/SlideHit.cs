using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessRunner
{
    class SlideHit : DoubleAction
    {
        public override void action1()
        {
            Slide slide = new Slide();
            slide.doAction();
        }
        public override void action2()
        {
            Hit hit = new Hit();
            hit.doAction();
        }
    }
}
