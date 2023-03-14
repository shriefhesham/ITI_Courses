using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal abstract class PlayerRole : Player
    {
        private Player player;

      
        public void SetComponent(Player player)
        {
            this.player = player;
        }

        public override void Functionality()
        {
            if( player != null)
            player.Functionality();
        }
    }
}
