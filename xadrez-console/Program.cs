using System;
using tabuleiro;
using xadrez;
namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeça(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeça(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.colocarPeça(new Rei(tab, Cor.Preta), new Posicao(0, 2));


                Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }


            Console.ReadLine();
        }
    }
}