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
            MovesContext jumpContext = new MovesContext(new Jump());
            jumpContext.executeAction();
            
            MovesContext movesContext1 = new MovesContext(new Hit());
            movesContext1.executeAction();

            MovesContext movesContext2 = new MovesContext(new Slide());
            movesContext2.executeAction();

            Console.ReadKey();
        }
    }
}
