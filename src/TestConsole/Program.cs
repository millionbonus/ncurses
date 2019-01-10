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
            //Curses.Data.Add("1", new CursesData("abc", 10, 10));
            //Curses.Data.Add("2", new CursesData("123", 20, 10, fg:ConsoleColor.Yellow));
            //Curses.Refresh();

            //Console.SetCursorPosition(20, 10);
            //Console.Write("000");
            //Curses.Render("2");

            Curses.ReadKeyEvent += Curses_ReadKeyEvent;
            Curses.Init();

            //Console.ReadKey();
        }

        private static void Curses_ReadKeyEvent(object sender, ReadKeyEventArgs e)
        {
            Curses.Write(Guid.NewGuid().ToString(), e.KeyInfo.KeyChar.ToString(), 1, 1);
            Curses.Refresh();
        }
    }
}
