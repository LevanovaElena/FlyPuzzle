using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyPuzzleBusinesLogic
{
    public interface IConsole
    {
        public void WriteLine(string message);
    }

    public class FlyConsole : IConsole
    {
        public List<string> Messages { get; set; } = new List<string>();
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
            Messages.Add(message);
        }
    }
}
