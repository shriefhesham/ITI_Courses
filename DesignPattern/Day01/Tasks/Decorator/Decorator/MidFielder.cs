using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class MidFielder : PlayerRole
    {


        public override void Functionality()
        {
            base.Functionality();
            MidFun();
        }

        public void MidFun()
        {
            Console.WriteLine("Dribble ");
        }
    }
}
