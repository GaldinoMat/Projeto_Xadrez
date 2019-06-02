using System;
using Xadrez_Console.Entities;
using Xadrez_Console.Entities.Enums;
using Xadrez_Console.Entities.Exceptions;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Partida_de_Xadrez partida = new Partida_de_Xadrez();
                
                while (!partida.Terminada)
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.Tab);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();

                    partida.ExecutaMovimento(origem, destino);
                }

                Tela.ImprimirTabuleiro(partida.Tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
