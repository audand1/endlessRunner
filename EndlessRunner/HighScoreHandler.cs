using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessRunner
{
    abstract class HighScoreHandler
    {
        protected HighScoreHandler successor;
        public void SetSuccessor(HighScoreHandler successor)
        {
            this.successor = successor;
        }
        public abstract void HandleRequest(int request);
    }
}
