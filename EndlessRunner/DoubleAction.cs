using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessRunner
{
    abstract class DoubleAction
    {
        public abstract void action1();
        public abstract void action2();
        
        public void doDoubleAction()
        {
            Console.WriteLine("-- Start double action ---");
            action1();
            action2();
            Console.WriteLine("-- Done double action ---");
        }
    }
}
