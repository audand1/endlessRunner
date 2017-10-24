using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessRunner
{
    public abstract class Player
    {
        public string name;
        public int speed;
        public abstract void add();
    }
}
