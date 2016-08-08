using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ConsoleApplication1
    {

        static void Main(string[] args)
        {
            clockradio radio = new clockradio("box", "black", 0, false);
            radio.TurnOn();
            Console.ReadLine();
        }
    }
}
