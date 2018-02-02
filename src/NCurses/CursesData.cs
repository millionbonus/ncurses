using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCurses.Lib
{
    public class CursesData
    {
        public string Text { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public ConsoleColor Foreground { get; set; }
        public ConsoleColor Background { get; set; }

        public CursesData(string text, int x, int y, 
                            ConsoleColor fg = ConsoleColor.White, ConsoleColor bg = ConsoleColor.Black)
        {
            this.Text = text;
            this.X = x;
            this.Y = y;
            this.Foreground = fg;
            this.Background = bg;
        }

    }
}
