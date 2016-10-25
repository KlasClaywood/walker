using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Walker
{
    class Program
    {
        static string map = "bb^^...............^^^bb|" +
                            "b^^..................^^b|" +
                            "^^....&&&&&&&&&&&&&...^^|" +
                            "....&&&&&..&&&&&.&&&&...|";

        //static string bulbasaur = @
        static void Main(string[] args)
        {
            Tile skog = new Tile('&', ConsoleColor.DarkGreen);
            Tile berg = new Tile('^', ConsoleColor.Gray);
            Tile toppar = new Tile('^', ConsoleColor.White);
            Tile grass = new Tile('.', ConsoleColor.Green);
            List<Position> karta = new List<Position>();
            List<Printable> allasaker = new List<Printable>();
            
            Player player = new Player(6, 1, new Tile('@', ConsoleColor.Gray));
            allasaker.Add(player);
            int x = 0;
            int y = 0;
            foreach (char c in map)
            {
                switch (c)
                {
                    case 'b':
                        karta.Add(new Position(x, y, toppar));
                        x++;
                        break;
                    case '^':
                        karta.Add(new Position(x, y, berg));
                        x++;
                        break;
                    case '.':
                        karta.Add(new Position(x, y, grass));
                        x++;
                        break;
                    case '&':
                        karta.Add(new Position(x, y, skog));
                        x++;
                        break;
                    case '|':
                        y++;
                        x = 0;
                        break;
                    default:
                        break;
                }
                
            }
            int i = 25;
            int index = 0;
            
            
            ConsoleKeyInfo svar = new ConsoleKeyInfo();
            svar = Console.ReadKey();
            while (svar.Key != ConsoleKey.Enter)
            {
                index = 0;
                Console.Clear();
                foreach (Position pos in karta)
                {
                    if (pos.Y > index)
                    {
                        index++;
                        Console.WriteLine();
                    }
                    PrintTile(pos.Tile);
                }
                foreach (Printable man in allasaker)
                {
                    Console.SetCursorPosition(man.Position.X, man.Position.Y);
                    PrintTile(man.Position.Tile);
                }
                svar = Console.ReadKey();
                switch (svar.Key)
                {
                    case ConsoleKey.NumPad7:
                        player.Position.X -= 1;
                        player.Position.Y -= 1;
                        break;
                    case ConsoleKey.NumPad8:
                        player.Position.Y -= 1;
                        break;
                    case ConsoleKey.NumPad9:
                        player.Position.X += 1;
                        player.Position.Y -= 1;
                        break;
                    case ConsoleKey.NumPad4:
                        player.Position.X -= 1;
                        break;
                    case ConsoleKey.NumPad6:
                        player.Position.X += 1;
                        break;
                    case ConsoleKey.NumPad1:
                        player.Position.X -= 1;
                        player.Position.Y += 1;
                        break;
                    case ConsoleKey.NumPad2:
                        player.Position.Y += 1;
                        break;
                    case ConsoleKey.NumPad3:
                        player.Position.X += 1;
                        player.Position.Y += 1;
                        break;
                    default:
                        break;
                }
            }
        }
        public static void PrintTile(Tile t)
        {
            Console.ForegroundColor = t.Color;
            Console.Write(t.Char);
        }
    }
}
