using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Operation
{
    internal class Math
    {

        public static int AddOp(int x, int y)
        {
            return x + y;
        }

        public static double DevideOp(double x, double y)
        {
            if (x == 0 || y == 0)
            { return -1; }
            return x / y;
        }
        public static int MultubelOp(int x, int y)
        {
            return x * y;
        }
        public static int SubtractOp(int x, int y)
        {
            return x - y;
        }
    }
}
