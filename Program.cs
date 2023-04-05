using jogo_xadrez.Tabuleiro;
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

          System.Console.Write("Origem: ");
          Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

          System.Console.Write("Destino: ");
          Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

          partida.executaMovimento(origem, destino);
        }

        Tela.imprimirTabuleiro(partida.tab);
      }
      catch (TabuleiroException e)
      {
        System.Console.WriteLine(e.Message);
      }

    }
  }
}