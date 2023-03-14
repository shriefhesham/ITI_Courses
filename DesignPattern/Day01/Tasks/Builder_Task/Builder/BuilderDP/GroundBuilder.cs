using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDP
{
    public abstract class GroundBuilder
    {
        protected Ground GroundObject;
        public abstract void SetGroundGallery();
        public abstract void SetGroundSurface();
        public abstract void SetGroundAudience();
        public void CreateNewGround()
        {
            GroundObject = new Ground();
        }
        public Ground GetGround()
        {
            return GroundObject;
        }
    }
}
