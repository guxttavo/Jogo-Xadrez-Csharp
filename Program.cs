using jogo_xadrez.Tabuleiro;
using xadrez;

namespace xadrez_console
{
  class Program
  {
    static void Main(string[] args)
    {

      Tabuleiro tab = new Tabuleiro(8, 8);

      tab.colocarPeca(new Torre(tab, Cor.Preto), new Posicao(1, 0));
      tab.colocarPeca(new Torre(tab, Cor.Preto), new Posicao(1, 1));
      tab.colocarPeca(new Rei(tab, Cor.Preto), new Posicao(1, 2));

      Tela.imprimirTabuleiro(tab);

      Console.ReadLine();
    }
  }
}