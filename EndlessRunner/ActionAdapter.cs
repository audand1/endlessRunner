using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessRunner
{
    class ActionAdapter : Action
    {
        private Bonuses bonuses;
        public ActionAdapter(Bonuses bonuses) {
            this.bonuses = bonuses;
        }
        public override void doAction()
        {
            bonuses.increaseSpeed();
        }
    }
}
