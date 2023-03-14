using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDP
{
    public class GroundDirector
    {
        public Ground MakeGround(GroundBuilder GroundBuilder)
        {
            GroundBuilder.CreateNewGround();
            GroundBuilder.SetGroundGallery();
            GroundBuilder.SetGroundSurface();
            GroundBuilder.SetGroundAudience();


            return GroundBuilder.GetGround();
        }
    }
}
