using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDP
{
    public class Ground
    {
        public string GroundGallery { get; set; }
        public string GroundSurface { get; set; }
        public string GroundAudience { get; set; }
        
        public void DisplayGround()
        {
            Console.WriteLine("Ground Gallery :" + GroundGallery);
            Console.WriteLine("Ground Surface :" + GroundSurface);
            Console.WriteLine("Ground Audeience :" + GroundAudience);
            
        }
    }
}
