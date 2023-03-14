using Observer_DP.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_DP.Model
{
    public class Referee : IObserver
    {
        public Point RefereeDirection;

        //public string RefereeName
        //{
        //    get { return RefereeName; }
        //    set { RefereeName = value; }
        //}


        public Ball bBall;
        public Referee(Ball _Ball)
        {
            bBall = _Ball;
            bBall.Attach(this);
            RefereeDirection.X = _Ball.position.X;
            RefereeDirection.Y = _Ball.position.Y;
        }

        //public void Update()
        //{
        //    Console.WriteLine($"playerName :{PlayerName} , follow the ball At : {PlayerDirection.X} , {PlayerDirection.Y}");
        //}

        public void Update()
        {
                            Console.WriteLine( $"Referee follow the ball At : {RefereeDirection.X} , {RefereeDirection.Y}");
            
        }
    }
}
