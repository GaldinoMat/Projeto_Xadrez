using System;
using System.Collections.Generic;
using System.Text;
using Xadrez_Console.Entities.Enums;

namespace Xadrez_Console.Entities
{
    class Torre : Peca
    {
        public Torre()
        {
        }

        public Torre(Cor cor, Tabuleiro tabuleiro) : base(cor, tabuleiro)
        {
        }

        public override string ToString()
        {
            return "T";
        }
    }
}
