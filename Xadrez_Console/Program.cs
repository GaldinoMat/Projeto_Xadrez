using System;
using Xadrez_Console.Entities;
using Xadrez_Console.Entities.Enums;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(0, 0));
            tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(1, 3));
            tab.ColocarPeca(new Rei(Cor.Branca, tab), new Posicao(2, 4));


            Tela.ImprimirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}
