# Welcome to NCurses #
NCurses is a Console wrapper which can help you do some screen-painting on console application more easier.

## License ##
Licensed under the MIT license.

## Installation ##

* Manual download
```
https://github.com/millionbonus/ncurses/releases
```

* Use package manager
``` bash
$ Install-Package NCurses
```

* Use .net cli
``` bash
$ dotnet add package NCurses
```

## Feature ##

## Usage ##

``` csharp
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
            //register read-key event
            Curses.ReadKeyEvent += Curses_ReadKeyEvent;

            //start readkey loop
            Curses.StartReadKey();
        }

        private static void Curses_ReadKeyEvent(object sender, ReadKeyEventArgs e)
        {
            var currKey = e.KeyInfo.Key.ToString();
            var mod = e.KeyInfo.Modifiers.ToString();

            Curses.Write("currKey", currKey, 1, 1);
            Curses.Write("mod", currKey, 1, 2);

            Curses.Refresh();
        }
    }
}
```
