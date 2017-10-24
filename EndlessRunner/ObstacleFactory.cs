using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessRunner
{
    public class ObstacleFactory
    {
        public static AbstractFactory getFactory(string choice)
        {
            if (string.Equals(choice.ToLower(), "shape"))
            {
                return new ShapeFactory();
            }
            else if (string.Equals(choice.ToLower(), "color"))
            {
                return new ColorFactory();
            }
            return null;
        }
    }
}
