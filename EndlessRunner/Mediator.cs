using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessRunner
{
    abstract class Mediator
    {
        public abstract void Send(Interlocutor sender, string message);
    }
}
