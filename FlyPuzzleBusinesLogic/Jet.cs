using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyPuzzleBusinesLogic
{
    public class Jet : Airplane
    {
        public int Multiplier { get; set; } = 2;



        public override void SetSpeed(int speed)
        {
            base.SetSpeed(speed * Multiplier);
        }


        public void Accelerate()
        {
            int currentSpeed = Speed;



            base.SetSpeed(currentSpeed * Multiplier);
        }

    }
}
