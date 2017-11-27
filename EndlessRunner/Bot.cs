using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessRunner
{
    class Bot : Interlocutor
    {
        public Bot(Mediator mediator)
            : base(mediator)
        {

        }
        public void Send(string msg)
        {
            mediator.Send(this, msg);
        }
        public void Notify(string msg)
        {
            Console.WriteLine("Bot gets msg: " + msg);
        }

    }
}
