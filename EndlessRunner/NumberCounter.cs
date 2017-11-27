using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessRunner
{
    class NumberCounter : Counter
    {
        private int value;
        public NumberCounter(int value)
        {
            this.value = value;
        }
        public override int count()
        {
            return value;
        }
    }
}
