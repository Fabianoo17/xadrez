using System;
using tabuleiro;
using xadrez.app.tabuleiro;
using xadrez.app.xadrez;

namespace xadrez.app
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(0, 0));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(7, 7));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(7, 6));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(7, 5));
            Tela.imprimirTabuleiro(tab);
            Console.ReadLine();
        }
    }
}
