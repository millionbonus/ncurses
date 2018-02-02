using NCurses.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Curses.Data.Add("1", new CursesData("abc", 10, 10));
            Curses.Data.Add("2", new CursesData("123", 20, 10, fg:ConsoleColor.Yellow));
            Curses.Refresh();

            Console.SetCursorPosition(20, 10);
            Console.Write("000");
            Curses.Render("2");

            Console.ReadKey();
        }
    }
}
