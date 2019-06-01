using System;
using Xadrez_Console.Entities;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            Console.WriteLine(tab);
        }
    }
}
