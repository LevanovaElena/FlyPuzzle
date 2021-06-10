using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyPuzzleBusinessLogic
{
    public class Jet :Airplane
    {
        private static int Multiplier { get; } = 2;
        private int _speed;

        public Jet():base()
        {

        }

        public override int Speed {

            get
            {
                return _speed;
            }
            set 
            {
                _speed = base.Speed * Multiplier;
            } 
        }

        public void Accelerate()
        {
            base.Speed = this.Speed * 2;
        }

    }
}
