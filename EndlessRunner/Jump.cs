using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessRunner
{
    class Jump : Action 
    {
       public override void doAction()
        {
            System.Console.WriteLine("Jump");
        }
    }
}
