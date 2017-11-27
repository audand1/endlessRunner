using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessRunner
{
    class PlusCounter : Counter
    {
        private Counter left, right;

        public PlusCounter(Counter _left, Counter _right)
        {
            this.left = _left;
            this.right = _right;
        }

        public override int count()
        {
            return left.count() + right.count();
        }
    }
}
