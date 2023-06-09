using Xadrez;

namespace jogo_xadrez.Tabuleiro
{
  public class Tela
  {
    public static void imprimirTabuleiro(Tabuleiro tabuleiro)
    {
      for (int i = 0; i < tabuleiro.linhas; i++)
      {
        Console.Write(8 - i + " ");
        for (int j = 0; j < tabuleiro.colunas; j++)
        {
          if (tabuleiro.peca(i, j) == null)
          {
            Console.Write("- ");
          }
          else
          {
            Tela.imprimirPeca(tabuleiro.peca(i, j));
            Console.Write(" ");
          }
        }
        Console.WriteLine();
      }
      System.Console.WriteLine("  a b c d e f g h");
    }

    public static PosicaoXadrez lerPosicaoXadrez()
    {
      string s = Console.ReadLine();
      char coluna = s[0];
      //converte um caractere em uma string vazia
      int linha = int.Parse(s[1] + "");
      return new PosicaoXadrez(coluna, linha);
    }

    public static void imprimirPeca(Peca peca)
    {
      if (peca.cor == Cor.Branca)
      {
        System.Console.Write(peca);
      }
      else
      {
        //salvando a cor atual(cinza)
        ConsoleColor aux = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Yellow;
        System.Console.Write(peca);
        Console.ForegroundColor = aux;
      }
    }
  }
}