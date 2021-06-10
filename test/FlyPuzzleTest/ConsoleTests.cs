using FlyPuzzleBusinesLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FlyPuzzleTest
{
    public class ConsoleTests
    {
        [Fact]
        public void ShouldBeAbleToWriteToConsole()
        {
            var console = new FlyConsole();
            console.WriteLine("Console was create!");
            Assert.Equal("Console was create!", console.Messages[0]);
        }


    }
}
