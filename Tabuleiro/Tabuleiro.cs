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

    /*
      Colocar uma peça P na posição pos, é ir na matriz de peças na posição
      pos.linha e pos.coluna e irá receber a peça P
    */
    public void colocarPeca(Peca p, Posicao pos)
    {
      pecas[pos.linha, pos.coluna] = p;
      p.posicao = pos;
    }
  }
}