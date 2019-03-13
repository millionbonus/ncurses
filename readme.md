# Welcome to NCurses #
NCurses is a Console wrapper which can help you do some screen-painting on console application more easier.

## License ##
Licensed under the MIT license.

## Feature ##

## Usage ##

```
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
            //register read key event
            Curses.ReadKeyEvent += Curses_ReadKeyEvent;

            //start readkey loop
            Curses.Init();
        }

        private static string[] history = new string[10];
        private static int i = 0;
        private static void Curses_ReadKeyEvent(object sender, ReadKeyEventArgs e)
        {
            //Curses.Write(Guid.NewGuid().ToString(), e.KeyInfo.Key.ToString(), 1, 1);

            var currKey = e.KeyInfo.Key.ToString() + "/" + e.KeyInfo.Modifiers.ToString();
            Curses.Write("currKey", currKey, 1, 1);

            history[i] = e.KeyInfo.KeyChar.ToString();
            Curses.Write("history", string.Join(",", history), 1, 2, fg: ConsoleColor.Black, bg: ConsoleColor.Green);
            Curses.Refresh();
            i = (i >= history.Length - 1) ? 0 : i+1;
        }
    }
}
```
