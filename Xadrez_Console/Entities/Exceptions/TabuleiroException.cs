using System;
using System.Collections.Generic;
using System.Text;

namespace Xadrez_Console.Entities.Exceptions
{
    class TabuleiroException : Exception
    {
        public TabuleiroException(string message) : base(message)
        {
        }
    }
}
