using System;

namespace FlyPuzzleBusinesLogic
{
    public class Airplane
    {
        private int _speed;

        public int Speed
        {
            set { _speed = value; }
            get { return _speed; }
        }

        public virtual void SetSpeed(int speed)
        {
            Speed = speed;
        }



    }
}
