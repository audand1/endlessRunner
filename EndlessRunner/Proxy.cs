using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessRunner
{
    class Proxy : DBSubject
    {
        private RealDB realDB;

        public override void insert(string text)
        {
            if (realDB == null)
            {
                realDB = new RealDB();
            }

            realDB.insert(text);

        }
    }
}
