using jogo_xadrez.Tabuleiro;

namespace Xadrez
{
  public class PosicaoXadrez
  {
    public char coluna { get; set; }
    public int linha { get; set; }

    public PosicaoXadrez(char coluna, int linha)
    {
      this.coluna = coluna;
      this.linha = linha;
    }

    //convertendo a posição do xadrez para uma posição interna da matriz
    public Posicao toPosicao()
    {
      return new Posicao(8 - linha, coluna - 'a');
    }

    public override string ToString()
    {
      return "" + coluna + linha;
    }

  }
}