using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessRunner
{
    class BackgroundContext
    {
        private State _state;
  
        public BackgroundContext(State state)
        {
            this._state = state;
        }

        public State State
        {
          get { return _state; }
          set 
          {
            _state = value;
            Console.WriteLine("State: " +  _state.GetType().Name);
            }
          }

        public void Request()
        {
          _state.Handle(this);
        }
    }
}
