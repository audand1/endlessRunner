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

            //template metod 
            MovesContext movesContextDoubleAction = new MovesContext(new JumpHit());
            movesContextDoubleAction.executeDoubleAction();

            movesContextDoubleAction = new MovesContext(new SlideHit());
            movesContextDoubleAction.executeDoubleAction();


            // state
            BackgroundContext backgroundContext = new BackgroundContext(new DayTime());
            backgroundContext.Request();
            backgroundContext.Request();
            backgroundContext.Request();
           
            //flyweight
            BackgroundFactory backgroundFactory = new BackgroundFactory();
            Background background = backgroundFactory.GetBackground("Lake");
            background.draw();
            background = backgroundFactory.GetBackground("Grass");
            background.draw();
            background = backgroundFactory.GetBackground("Forest");
            background.draw();
            // kviecia antra kart
            background = backgroundFactory.GetBackground("Lake");
            background.draw();
            background = backgroundFactory.GetBackground("Grass");
            background.draw();
            background = backgroundFactory.GetBackground("Forest");
            background.draw();

            // proxy 
            Proxy proxy = new Proxy();
            proxy.insert("High score 1010");

            // chain of resp.
            Console.WriteLine("Points at start:" + Config.getInstance.points);
            HighScoreHandler h1 = new PositiveHandler();
            HighScoreHandler h2 = new NegativeHandler();
            HighScoreHandler h3 = new NullObject();
            h1.SetSuccessor(h2);
            h2.SetSuccessor(h3);
            int[] requests = { 2, -5, -14, 22, 0, -18, 3, 27, -20, 12, 0, 12, 30 };
            foreach (int request in requests)
            {
                h1.HandleRequest(request);
            }
            Console.WriteLine("Final score:" + Config.getInstance.points);

            //memento    
            Console.WriteLine("Points before saving:" + Config.getInstance.points);
            GameTaker gameTaker = new GameTaker();
            gameTaker.Memento = Config.getInstance.CreateMemento();
            Config.getInstance.points = 100;
            Console.WriteLine("new points value :" + Config.getInstance.points);
            Config.getInstance.SetMemento(gameTaker.Memento);
            Console.WriteLine("Points after restore:" + Config.getInstance.points);

            // interpreter
            Console.WriteLine("Counter before interpreter:" + Config.getInstance.counter);
            Counter counter1 = new NumberCounter(Config.getInstance.counter);
            Counter counter2 = new NumberCounter(5);
            Counter counter = new PlusCounter(counter1, counter2);

            Config.getInstance.counter = counter.count();
            Console.WriteLine("Counter after interpreter:" + Config.getInstance.counter);

            //mediator
            ConcreteMediator mediator = new ConcreteMediator();
            Bot b = new Bot(mediator);
            User u = new User(mediator);
            mediator.SetBot(b);
            mediator.SetUser(u);
            string resp = string.Empty;
            while(!resp.ToLower().Equals("geras"))
            {
                b.Send("Kaip tau žaidimas?");

                 resp = Console.ReadLine();

                u.Send(resp);
            }
            Console.ReadKey();
        }
    }
}
