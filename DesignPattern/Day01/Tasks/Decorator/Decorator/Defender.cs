﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Defender : PlayerRole
    {

        public override void Functionality()
        {
            base.Functionality();
            DefenderFun();
        }

        public void DefenderFun()
        {
            Console.WriteLine(" Defend  ");
        }
    }
}
