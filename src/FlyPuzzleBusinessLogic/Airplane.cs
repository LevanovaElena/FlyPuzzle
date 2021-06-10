﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyPuzzleBusinessLogic
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
