using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessRunner
{
    abstract class Stuff
    {
        protected DrawAPI drawAPI;
        protected Stuff(DrawAPI drawAPI)
        {
            this.drawAPI = drawAPI;
        }
        protected abstract void draw();
    }
}
