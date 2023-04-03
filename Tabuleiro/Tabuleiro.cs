namespace jogo_xadrez.Tabuleiro
{
  public class Tabuleiro
  {
    public int linhas { get; set; }
    private int colunas { get; set; }

    //Essa matriz vai ter um tamanho definido pela quantidade de linhas e colunas do tabuleiro
    private Peca[,] pecas;

    public Tabuleiro(int linhas, int colunas)
    {
      this.linhas = linhas;
      this.colunas = colunas;
      //peças vai receber uma nova matriz de peças, onde tal matriz vai ter o 
      //numero de linhas e colunas informadas 
      pecas = new Peca[linhas, colunas];
    }
  }
}