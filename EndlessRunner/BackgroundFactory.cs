using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessRunner
{
    class BackgroundFactory
    {
        private Hashtable background = new Hashtable();

      
        public Background GetBackground(string backgroundType)
        {
            Background b = (Background)background[backgroundType];

            if (b == null)
            {
                if (backgroundType.Equals("Lake"))
                {
                    b = new Lake();
                }
                else if (backgroundType.Equals("Grass"))
                {
                   b = new Grass();
                }
                else if (backgroundType.Equals("Forest"))
                {
                    b = new Forest();
                }

                background.Add(backgroundType,b);
            }
            return b;
        }
    }
}
