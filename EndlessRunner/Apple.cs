using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessRunner
{
     class Apple : Stuff
    {
      //  DrawAPI drawAPI;
          
        public Apple(DrawAPI drawAPI)
        {
            this.drawAPI = drawAPI;
        }

        public override void draw()
        {
            drawAPI.putStuff();
        }

    }
}
