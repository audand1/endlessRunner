using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessRunner
{
   public class ShapeFactory : AbstractFactory
    {
        public override Shape getShape(string shapeType)
        {
            if (shapeType == null)
            {
                return null;
            }
            if (string.Equals(shapeType.ToUpper(), 'POLE'))
            {
                return new Pole();
            }
            else if (string.Equals(shapeType.ToUpper(), 'TREE'))
            {
                return new Tree();
            }
            else if (string.Equals(shapeType.ToUpper(), 'CLOUD'))
            {
                return new Cloud();
            }
            else if (string.Equals(shapeType.ToUpper(), 'STONE'))
            {
                return new Stone();
            }
            return null;
        }

        override Color getColor(string color)
        {
            return null;
        }
    }
}
