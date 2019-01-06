using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HouseBuilding
{
    class Program
    {
        static void Main(string[] args)
        {
            Building ctroika = new Building();
            ctroika.startCt();
            Paint();
            Console.ReadLine();
        }

        static void Paint()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("                      +                        ");
            Thread.Sleep(100);
            Console.WriteLine("                     +++                       ");
            Thread.Sleep(100);
            Console.WriteLine("                  +++++++++                    ");
            Thread.Sleep(100);
            Console.WriteLine("              ++++++++++++++++++               ");
            Thread.Sleep(100);
            Console.WriteLine("         +++++++++++++++++++++++++++++         ");
            Thread.Sleep(100);
            Console.WriteLine("     ++++++++++++++++++++++++++++++++++++++    ");
            Thread.Sleep(100);
            Console.WriteLine("   +++++++++++++++++++++++++++++++++++++++++   ");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(100);
            Console.WriteLine("  |-----------------------------------------|  ");
            Thread.Sleep(100);
            Console.WriteLine("  |**__________*****************__________**|  ");
            Thread.Sleep(100);
            Console.WriteLine("  |**|        |*****************|        |**|  ");
            Thread.Sleep(100);
            Console.WriteLine("  |**|        |*****************|        |**|  ");
            Thread.Sleep(100);
            Console.WriteLine("  |**|        |*****************|        |**|  ");
            Thread.Sleep(100);
            Console.WriteLine("  |**|        |*****************|        |**|  ");
            Thread.Sleep(100);
            Console.WriteLine("  |**|________|*****************|________|**|  ");
            Thread.Sleep(100);
            Console.WriteLine("  |*****************************************|  ");
            Thread.Sleep(100);
            Console.WriteLine("  |*****************************************|  ");
            Thread.Sleep(100);
            Console.WriteLine("  |-----------------------------------------|  ");
            Thread.Sleep(100);
            Console.WriteLine("  |**__________**_____________**__________**|  ");
            Thread.Sleep(100);
            Console.WriteLine("  |**|        |**|-----------|**|        |**|  ");
            Thread.Sleep(100);
            Console.WriteLine("  |**|        |**|-----------|**|        |**|  ");
            Thread.Sleep(100);
            Console.WriteLine("  |**|        |**|-----------|**|        |**|  ");
            Thread.Sleep(100);
            Console.WriteLine("  |**|        |**|-----------|**|        |**|  ");
            Thread.Sleep(100);
            Console.WriteLine("  |**|________|**|-----------|**|________|**|  ");
            Thread.Sleep(100);
            Console.WriteLine("  |**************|-----------|**************|  ");
            Thread.Sleep(100);
            Console.WriteLine("  |**************|___________|**************|  ");
            Thread.Sleep(100);
            Console.WriteLine("  |-----------------------------------------|  ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Thread.Sleep(100);
            Console.WriteLine("  |||||||||||||||||||||||||||||||||||||||||||  ");
            Thread.Sleep(100);
            Console.WriteLine("  |||||||||||||||||||||||||||||||||||||||||||  ");

        }
    }
}
