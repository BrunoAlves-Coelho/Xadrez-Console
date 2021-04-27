using System;
using Xadrez_Console.tabuleiro;
using Xadrez_Console.xadrez;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {

            //PosicaoXadrez pos = new PosicaoXadrez('c', 7);
            //
            //Console.WriteLine(pos);
            //
            //Console.WriteLine(pos.toPosicao());

            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);
            
                tab.ColocarPecas(new Torre(Cor.Preta, tab), new Posicao(0, 0));
                tab.ColocarPecas(new Torre(Cor.Preta, tab), new Posicao(1, 3));
                tab.ColocarPecas(new Rei(Cor.Preta, tab), new Posicao(0, 2));

                tab.ColocarPecas(new Torre(Cor.Branca, tab), new Posicao(3, 5));

                Tela.ImprimirTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
           
            
        }
    }
}
