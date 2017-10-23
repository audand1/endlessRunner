using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessRunner
{
   public abstract class AbstractFactory
    {
        abstract Color getColor(string color);
        abstract Shape getShape(string shape);
    }
}
