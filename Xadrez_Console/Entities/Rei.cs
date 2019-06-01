using Xadrez_Console.Entities.Enums;

namespace Xadrez_Console.Entities
{
    class Rei : Peca
    {
        public Rei()
        {
        }

        public Rei(Cor cor, Tabuleiro tabuleiro) : base(cor, tabuleiro)
        {
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
