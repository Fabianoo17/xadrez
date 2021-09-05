using System;
using tabuleiro;

namespace xadrez.app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Posicao P = new Posicao(3, 4);
            Console.WriteLine(P);
            Console.ReadLine();
        }
    }
}
