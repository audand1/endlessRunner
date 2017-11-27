using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessRunner
{
    abstract class Interlocutor
    {
        protected Mediator mediator;
        public Interlocutor(Mediator _mediator)
        {
            this.mediator = _mediator;
        }
    }
}
