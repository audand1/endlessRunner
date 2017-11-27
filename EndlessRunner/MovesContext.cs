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
        private DoubleAction doubleAction;
        public MovesContext(Action action)
        {
            this.action = action;
        }
        public MovesContext(DoubleAction action)
        {
            this.doubleAction = action;
        }
        public void executeAction()
        {
            action.doAction();
        }
        public void executeDoubleAction()
        {
            doubleAction.doDoubleAction();
        }
    }
}
