using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Walker
{
    class Tile
    {
        public char Char { private set; get; }
        public ConsoleColor Color { private set; get; }
        public Tile (char c, ConsoleColor col)
        {
            this.Char = c;//klas

            this.Color = col;

        }
    }
}
