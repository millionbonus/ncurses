using System;
using System.Runtime.Serialization;

namespace NCurses.Lib
{
    [Serializable]
    internal class CursesDataNotFoundException : Exception
    {
        //public CursesDataNotFound()
        //{
        //}

        public CursesDataNotFoundException(string key) : base("Can not found " + key + " in Curses Data.")
        {
        }

        //public CursesDataNotFound(string message, Exception innerException) : base(message, innerException)
        //{
        //}

        //protected CursesDataNotFound(SerializationInfo info, StreamingContext context) : base(info, context)
        //{
        //}
    }
}