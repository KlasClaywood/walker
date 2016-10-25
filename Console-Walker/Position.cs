using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Walker
{
    class Position
    {
        public int X { set; get; }
        public int Y { set; get; }
        public Tile Tile { private set; get; }
        public Position (int x, int y, Tile tile)
        {
            this.Tile = tile;
            this.X = x;
            this.Y = y;
        }
    }
}
