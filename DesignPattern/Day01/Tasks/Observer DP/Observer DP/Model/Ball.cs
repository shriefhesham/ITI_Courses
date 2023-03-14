using Observer_DP.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_DP.Model
{
    public class Ball :ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();

        public Point position;
        
        public Point Position 
        {
         get => position;
            set 
            {
                position = value;
                //Notify();
            }
        }

        public Ball(Point _Position)
        { 
          position.X= _Position.X;
          position.Y= _Position.Y;
        }


        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IObserver o in _observers)
            {
                o.Update();
            }
        }
    }
}
