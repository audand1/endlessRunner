using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessRunner
{
     class Peach : Stuff
    {
       // DrawAPI drawAPI;
        
        public Peach(DrawAPI drawAPI)
        {
            this.drawAPI = drawAPI;
        }

        public override void draw()
        {
            drawAPI.putStuff();
        }
    }
}
