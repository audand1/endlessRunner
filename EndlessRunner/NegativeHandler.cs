using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessRunner
{
    class NegativeHandler : HighScoreHandler
    {
        public override void HandleRequest(int request)
        {
            if (request < 0)
            {
                Console.WriteLine("{0} handled request {1}",
                    this.GetType().Name, request);
                Config.getInstance.points += request;
            }
            else if (successor != null)
            {
                successor.HandleRequest(request);
            }
        }
    }
}
