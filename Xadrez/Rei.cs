using jogo_xadrez.Tabuleiro;

namespace xadrez
{
  class Rei : Peca
  {
    /*
      -Base é responsável por mandar os parâmetros da classe derivada para classe base
      -Isso é importante pois está garantindo que o construtor da classe base seja inicializado
       primeiro que o construtor da classe derivada
      -Se a classe base não for inicializada primeiro, a classse derivada pode acbar em um estado
       inconsistente ou com membros não inicializados
    */
    public Rei(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
    {
    }

    public override string ToString()
    {
      return "R";
    }

    private bool podeMover(Posicao pos)
    {
      Peca p = tabuleiro.peca(pos);
      return p == null || p.cor != cor;
    }

    public override bool[,] movimentosPossiveis()
    {
      bool[,] mat = new bool[tabuleiro.linhas, tabuleiro.colunas];

      Posicao pos = new Posicao(0, 0);

      //acima
      pos.definirValores(posicao.linha - 1, posicao.coluna);
      if (tabuleiro.posicaoValida(pos) && podeMover(pos))
      {
        mat[pos.linha, pos.coluna] = true;
      }
      //nordeste
      pos.definirValores(posicao.linha - 1, posicao.coluna + 1);
      if (tabuleiro.posicaoValida(pos) && podeMover(pos))
      {
        mat[pos.linha, pos.coluna] = true;
      }
      //direita
      pos.definirValores(posicao.linha, posicao.coluna + 1);
      if (tabuleiro.posicaoValida(pos) && podeMover(pos))
      {
        mat[pos.linha, pos.coluna] = true;
      }
      //sudeste
      pos.definirValores(posicao.linha + 1, posicao.coluna + 1);
      if (tabuleiro.posicaoValida(pos) && podeMover(pos))
      {
        mat[pos.linha, pos.coluna] = true;
      }
      //abaixo
      pos.definirValores(posicao.linha + 1, posicao.coluna);
      if (tabuleiro.posicaoValida(pos) && podeMover(pos))
      {
        mat[pos.linha, pos.coluna] = true;
      }
      //sudoeste
      pos.definirValores(posicao.linha + 1, posicao.coluna - 1);
      if (tabuleiro.posicaoValida(pos) && podeMover(pos))
      {
        mat[pos.linha, pos.coluna] = true;
      }
      //esquerda
      pos.definirValores(posicao.linha, posicao.coluna - 1);
      if (tabuleiro.posicaoValida(pos) && podeMover(pos))
      {
        mat[pos.linha, pos.coluna] = true;
      }
      //noroeste
      pos.definirValores(posicao.linha - 1, posicao.coluna - 1);
      if (tabuleiro.posicaoValida(pos) && podeMover(pos))
      {
        mat[pos.linha, pos.coluna] = true;
      }
      return mat;
    }
  }
}