using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessRunner
{
   public abstract class AbstractFactory
    {
        abstract public Color getColor(string color);
        abstract public Shape getShape(string shape);
    }
}
