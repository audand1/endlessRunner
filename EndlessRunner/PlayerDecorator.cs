using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessRunner
{
    class PlayerDecorator: Player
    {
        protected Player decoratedPlayer;
        public PlayerDecorator() { }
        public PlayerDecorator(Player decoratedPlayer)
        {
            this.decoratedPlayer = decoratedPlayer;
        }

        public override void add()
        {
            decoratedPlayer.add();
        }
    }
}
