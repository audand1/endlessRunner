using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessRunner
{
    class MovesContext
    {
        private Action action;
        public MovesContext(Action action)
        {
            this.action = action;
        }
        public void executeAction()
        {
            action.doAction();
        }
    }
}
