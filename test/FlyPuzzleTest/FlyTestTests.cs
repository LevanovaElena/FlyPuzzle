using System;
using System.Collections.Generic;
using System.Linq;
using FlyPuzzle;
using System.Threading.Tasks;
using Xunit;

namespace FlyPuzzleTest
{
    public class FlyTestTests
    {
        [Fact]
        public void ShouldBeCreateFlyTest()
        {
            FlyTest fly = new FlyTest();
            Assert.NotNull( fly.console);
            fly.RunFlyTest();
            Assert.Equal("212", fly.console.Messages[0]);
            Assert.Equal("844", fly.console.Messages[1]);
            Assert.Equal("1688", fly.console.Messages[2]);
            Assert.Equal("6752", fly.console.Messages[3]);
            Assert.Equal("13504", fly.console.Messages[4]);
            Assert.Equal("27008", fly.console.Messages[5]);
            Assert.Equal("1696", fly.console.Messages[6]);
        }
        [Fact]
        public void ShouldBeCreateProgram()
        {
            Program program = new Program();
            Assert.NotNull(program);
            Program.Main(new string[0]);
        }
    }
}
