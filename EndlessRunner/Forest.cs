using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessRunner
{
    class Forest : Background
    {
        public Forest()
        {
            Console.WriteLine("init FOREST object");
        }
        public override void draw()
        {
            Console.WriteLine("draw FOREST ");
        }
    }
}
