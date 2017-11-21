using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessRunner
{
    class RealDB: DBSubject
    {
        public override void insert(string text)
        {
            Console.WriteLine("the text (" + text + ") is inserted in the database");
        }
    }
}
