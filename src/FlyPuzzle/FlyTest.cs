using FlyPuzzleBusinesLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyPuzzle
{
    public class FlyTest
    {
       public FlyConsole console { get; } = new FlyConsole();

        public void RunFlyTest()
        {
            Airplane biplane = new Airplane();
            biplane.SetSpeed(212);
            console.WriteLine(biplane.Speed.ToString());
            Jet boing = new Jet();
            boing.SetSpeed(422);
            console.WriteLine(boing.Speed.ToString());
            int x = 0;
            while (x < 4)
            {
                boing.Accelerate();
                console.WriteLine(boing.Speed.ToString());
                if (boing.Speed > 5000)
                {
                    biplane.SetSpeed(biplane.Speed * 2);
                }
                else boing.Accelerate();
                x++;
            }
            console.WriteLine(biplane.Speed.ToString());
        }
    }
}
