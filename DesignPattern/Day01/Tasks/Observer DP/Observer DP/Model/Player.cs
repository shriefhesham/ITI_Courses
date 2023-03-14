using Observer_DP.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_DP.Model
{
    public class Player : IObserver
    {
        public Point PlayerDirection ;
        
        
        
    
        public Ball bBall;
        public Player(Ball _Ball) 
        {
            this.bBall = _Ball;
            bBall.Attach(this);
            PlayerDirection.X = bBall.position.X;
            PlayerDirection.Y = bBall.position.Y;
        }

        //public void Update()
        //{
        //    Console.WriteLine($"playerName :{PlayerName} , follow the ball At : {PlayerDirection.X} , {PlayerDirection.Y}");
        //}

        public void Update()
        {
            //if (subject is Ball ball)
            //{
            //}
            Console.WriteLine($"player follow the ball At : {PlayerDirection.X} , {PlayerDirection.Y}");

        }
    }
}
