using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessRunner
{
    public class ColorFactory : AbstractFactory
    {
        public override Shape getShape(string shape)
        {
            return null;
        }

       public override Color getColor(string color)
        {
            if (color == null)
            {
                return null;
            }
            if (string.Equals(color.ToUpper(), "GREEN"))
            {
                return new Green();
            }
            else if (string.Equals(color.ToUpper(), "YELLOW"))
            {
                return new Yellow();
            }
            else if (string.Equals(color.ToUpper(), "RED"))
            {
                return new Red();
            }
            return null;
        }
    }
}
