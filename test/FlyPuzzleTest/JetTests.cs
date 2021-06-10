
using FlyPuzzleBusinesLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FlyPuzzleTest
{
    public class JetTests
    {
        [Fact]
        public void ShoulBeCreateJet()
        {
            Jet jet = new Jet();
            jet.SetSpeed(1000);
            Assert.Equal(2000, jet.Speed);
        }

        [Fact]
        public void ShoulAccelerateParent()
        {
            Jet jet = new Jet();
            jet.SetSpeed(1000);
            jet.Accelerate();
            Assert.Equal(4000, jet.Speed);
            
            
        }


    }
}
