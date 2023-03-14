using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Forward : PlayerRole
    {
       
        
        public override void Functionality()
        {
            base.Functionality();
            ForwradFun();
        }

        public void ForwradFun() 
        {
            Console.WriteLine(" Shoot Goaal ");
        }
    }
}
