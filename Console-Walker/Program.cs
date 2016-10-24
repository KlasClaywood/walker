using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Walker
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo svar = new ConsoleKeyInfo();
            svar = Console.ReadKey();
            while (svar.Key != ConsoleKey.NumPad5)
            {
                Console.WriteLine(svar.Key);
                svar = Console.ReadKey();
            }
        }
    }
}
