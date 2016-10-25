using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Walker
{
    class Printable
    {
        public Position Position { set; get; }
        public Printable(int x, int y, Tile tile)
        {
            this.Position = new Position(x, y, tile);
        }

    }
}
