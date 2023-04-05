namespace jogo_xadrez.Tabuleiro
{
  public class Tabuleiro
  {
    public int linhas { get; set; }
    public int colunas { get; set; }
    //Essa matriz vai ter um tamanho definido pela quantidade de linhas e colunas do tabuleiro
    private Peca[,] pecas;
    public Tabuleiro(int linhas, int colunas)
    {
      this.linhas = linhas;
      this.colunas = colunas;
      /*
       Peças vai receber uma nova matriz de peças, onde tal matriz vai ter o 
       numero de linhas e colunas informadas
       */
      pecas = new Peca[linhas, colunas];
    }
    /*
      Como o acesso direto a matriz está bloqueado, é necessário criar um método
      para dar acesso individual a uma peça
    */
    public Peca peca(int linha, int coluna)
    {
      return pecas[linha, coluna];
    }

    public Peca peca(Posicao pos)
    {
      return pecas[pos.linha, pos.coluna];
    }
    /*
      Colocar uma peça P na posição pos, é ir na matriz de peças na posição
      pos.linha e pos.coluna e irá receber a peça P
    */
    public void colocarPeca(Peca p, Posicao pos)
    {
      if (existePeca(pos))
      {
        throw new TabuleiroException("Já existe uma peça nessa posição!");
      }
      pecas[pos.linha, pos.coluna] = p;
      p.posicao = pos;
    }

    public Peca retirarPeca(Posicao pos)
    {
      if (peca(pos) == null)
      {
        return null;
      }
      Peca aux = peca(pos);
      aux.posicao = null;
      pecas[pos.linha, pos.coluna] = null;
      return aux;
    }

    //Validacoes:
    public bool existePeca(Posicao pos)
    {
      validarPosicao(pos);
      return peca(pos) != null;
    }
    public void validarPosicao(Posicao pos)
    {
      if (!posicaoValida(pos))
      {
        throw new TabuleiroException("Posicao inválida!");
      }
    }
    public bool posicaoValida(Posicao pos)
    {
      if (pos.linha < 0 || pos.linha >= linhas || pos.coluna < 0 || pos.coluna >= colunas)
      {
        return false;
      }
      return true;
    }
  }
}