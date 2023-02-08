using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    internal class Point3D
    {
        int x, y, z;

        public Point3D(int _x , int _y , int _z )
        {
            x = _x;
            y = _y;
            z = _z;
        }

        public int X 
        {
            set { x = value; }
            get { return x; }
        }
        public int Y
        {
            set { y = value; }
            get { return y; }
        }
        public int Z
        {
            set { z = value; }
            get { return z; }
        }

        public override string ToString()
        {

            return $" X : {x} , Y : {y} , Z : {z}";
        }

        public override bool Equals(object? obj)
        {
            if(obj is Point3D)
                 return this.x == ((Point3D)obj).x && this.y == ((Point3D)obj).y;
            return false;
        }






        //public override int GetHashCode()
        //{
        //    return ToString().GetHashCode();
        //}



    }
}
