using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            //singleton
            Config.getInstance.readConfigFile();

            // strategy
            MovesContext jumpContext = new MovesContext(new Jump());
            jumpContext.executeAction();
            
            MovesContext movesContext1 = new MovesContext(new Hit());
            movesContext1.executeAction();

            MovesContext movesContext2 = new MovesContext(new Slide());
            movesContext2.executeAction();

            //adapter
            MovesContext movesContextAdapter = new MovesContext(new ActionAdapter(new Bonuses()));
            movesContextAdapter.executeAction();


            // facade, factory, absract factory
            ObstacleFacade obstacleMaker = new ObstacleFacade();
            obstacleMaker.drawBlueCloud();
            obstacleMaker.drawGreenTree();
            obstacleMaker.drawGreyPole();
            obstacleMaker.drawRedStone();
            obstacleMaker.drawYellowStone();

            // bridge
            Stuff positiveApple = new Apple(new PositiveStuff());
            Stuff negativeApple = new Apple(new NegativeStuff());

            Stuff positivePeach = new Peach(new PositiveStuff());
            Stuff negativePeach = new Peach(new NegativeStuff());

            positiveApple.draw();
            negativeApple.draw();

            positivePeach.draw();
            negativePeach.draw();

            // decorator
            Player player = new Boy();
            Player fastPlayer = new FastPlayerDecorator(new Boy());
            fastPlayer.add();
            player.add();


           

            Console.ReadKey();
        }
    }
}
