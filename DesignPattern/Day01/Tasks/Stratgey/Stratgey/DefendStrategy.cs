using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratgey
{
    internal class DefendStrategy : Strategy
    {
        public override void TeamStrategy()
        {
            Console.WriteLine(" The team now applies the defence strategy ");
        }
    }
}
