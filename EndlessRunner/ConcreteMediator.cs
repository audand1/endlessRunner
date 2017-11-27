using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessRunner
{
    class ConcreteMediator : Mediator
    {
        private Bot bot;
        private User user;

        public void SetBot(Bot value)
        {
            bot = value;
        }
        public void SetUser(User value)
        {
            user = value;
        }

        public override void Send(Interlocutor sender, string message)
        {
            if (sender.Equals(user))
            {
                bot.Notify(message);
            }else if (sender.Equals(bot))
            {
                user.Notify(message);
            }
        }
    }
}
