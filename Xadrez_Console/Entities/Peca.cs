using System;
using System.Collections.Generic;
using System.Text;
using Xadrez_Console.Entities.Enums;

namespace Xadrez_Console.Entities
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public Tabuleiro Tabuleiro { get; protected set; }

        public Peca()
        {
        }

        public Peca(Posicao posicao, Cor cor, Tabuleiro tabuleiro)
        {
            Posicao = posicao;
            Cor = cor;
            Tabuleiro = tabuleiro;
            QteMovimentos = 0;
        }
    }
}
