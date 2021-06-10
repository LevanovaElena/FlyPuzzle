
using FlyPuzzleBusinesLogic;
using System;
using Xunit;


namespace FlyPuzzleTest
{
    public class AirplaneTests
    {
        [Fact]
        public void ShoulBeCreateAirplane()
        {
            Airplane airplane = new Airplane();
            airplane.Speed = 1000;
            Assert.Equal(1000, airplane.Speed);
            airplane.SetSpeed(2000);
            Assert.Equal(2000, airplane.Speed);
        }
    }
}
