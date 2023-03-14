using Observer_DP.Model;
using System.Drawing;

namespace Observer_DP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(3, 4);
            Point p2 = new Point(5, 5);
            Ball ball1 = new Ball(p2);
            Player Player1 = new(ball1);
            Referee referee1 = new(ball1);
            
            ball1.Notify();
        }
    }
}