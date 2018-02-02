using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCurses.Lib
{
    public class Curses
    {
        public static Dictionary<string, CursesData> Data = new Dictionary<string, CursesData>();
        public static bool CursorVisible = false;

        private static void writeAt(CursesData cd)
        {
            writeAt(cd.Text, cd.X, cd.Y, cd.Foreground, cd.Background);
        }
        private static void writeAt(string s, int x, int y,
                                    ConsoleColor fg = ConsoleColor.White, ConsoleColor bg = ConsoleColor.Black)
        {
            try
            {
                Console.ForegroundColor = fg;
                Console.BackgroundColor = bg;
                Console.SetCursorPosition(x, y);
                Console.Write(s);
            }
            catch (ArgumentOutOfRangeException e)
            {
                //Console.Clear();
                //Console.WriteLine(e.Message);
            }
        }

        public static void Refresh()
        {
            Clear();
            Render();
        }

        /// <summary>
        /// Render curses data on the screen.
        /// </summary>
        /// <param name="key">If key is given. Only render the CursesData. If key is not given. render all CursesData.</param>
        public static void Render(string key="")
        {
            Console.CursorVisible = CursorVisible;
            if (string.IsNullOrEmpty(key))
            {
                foreach(var d in Data.Values)
                {
                    writeAt(d);
                }
            }
            else
            {
                if (Data.ContainsKey(key))
                {
                    writeAt(Data[key]);
                }
                else
                {
                    throw new CursesDataNotFound(key);
                }
            }
        }

        public static void Clear()
        {
            Console.Clear();
        }

    }
}
