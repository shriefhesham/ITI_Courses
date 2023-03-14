using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class GoalKeeper : Player
    {
       
        public override void Functionality()
        {
            
            Console.WriteLine("Pass the ball");
        }
    }
}
