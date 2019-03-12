using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NCurses.Lib
{
    public class ReadKeyEventArgs : EventArgs
    {
        public ConsoleKeyInfo KeyInfo;
        public ReadKeyEventArgs(ConsoleKeyInfo keyinfo)
        {
            this.KeyInfo = keyinfo;
        }
    }
}
