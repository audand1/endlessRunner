using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessRunner
{
    class FastPlayerDecorator : PlayerDecorator
    {
        public FastPlayerDecorator(Player decoratedPlayer)
        {
            this.decoratedPlayer = decoratedPlayer;
        }

        public override void add()
        {
            decoratedPlayer.add();
            addSpeed(decoratedPlayer,50);
        }

        private void addSpeed(Player player,int speed)
        {
            Console.WriteLine("Change speed: " + speed);
            player.speed += speed;
        }
    }
}
