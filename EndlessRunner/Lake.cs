using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessRunner
{
    class Lake : Background
    {
         public Lake()
        {
            Console.WriteLine("init LAKE object");
        }
        public override void draw()
        {
            Console.WriteLine("draw LAKE ");
        }
    }
}
