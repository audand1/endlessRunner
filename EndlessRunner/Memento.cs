using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessRunner
{
    class Memento
    {
        private int points;
        public Memento(int state)
        {
            this.points = state;
        }

        public int GetPoints()
        {
            return points; 
        }
        public void SetPoints(int state)
        {
            this.points = state;
        }
    }
}
