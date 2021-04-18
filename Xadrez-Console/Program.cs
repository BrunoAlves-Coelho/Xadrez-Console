using System;
using Xadrez_Console.tabuleiro;
using Xadrez_Console.xadrez;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {

            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.ColocarPecas(new Torre(Cor.Preta, tab), new Posicao(0, 0));
            tab.ColocarPecas(new Torre(Cor.Preta, tab), new Posicao(1, 3));
            tab.ColocarPecas(new Rei(Cor.Preta, tab), new Posicao(2, 4));

            Tela.ImprimirTabuleiro(tab);
            
            //Posicao p = new Posicao(3, 4);
            
            //Console.WriteLine("Posição: " + p);
        }
    }
}
