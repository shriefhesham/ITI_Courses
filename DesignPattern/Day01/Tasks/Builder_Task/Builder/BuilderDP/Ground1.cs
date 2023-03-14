using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDP
{
    public class Ground1 : GroundBuilder
    {
        public override void SetGroundAudience()
        {
            GroundObject.GroundGallery = "Ground Gallery";
        }

        public override void SetGroundGallery()
        {
            GroundObject.GroundSurface = "Ground Surface";
        }

        public override void SetGroundSurface()
        {
            GroundObject.GroundAudience = "Ground Audience";
        }
    }
}
