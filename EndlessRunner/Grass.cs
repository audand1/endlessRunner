using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessRunner
{
    class Grass : Background
    {
         public Grass()
        {
            Console.WriteLine("init GRASS object");
        }
        public override void draw()
        {
            Console.WriteLine("draw GRASS ");
        }
    }
}
