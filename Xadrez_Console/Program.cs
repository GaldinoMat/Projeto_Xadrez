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
                PosicaoXadrez pos = new PosicaoXadrez('c', 7);

                Console.WriteLine(pos);

                Console.WriteLine(pos.ToPosicao());
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
