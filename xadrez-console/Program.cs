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
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.Write("digite a origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                    bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentoPossiveis();

                    Console.Clear(); 
                    Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

                    Console.Write("digite o destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem, destino);

                }
                Tela.imprimirTabuleiro(partida.tab);

                Console.WriteLine();
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
