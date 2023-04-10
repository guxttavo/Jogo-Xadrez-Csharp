namespace jogo_xadrez.Tabuleiro
{
  public abstract class Peca
  {
    //Uma peça está em alguma posição
    public Posicao posicao { get; set; }
    //A cor pode ser acessada por outras classes mas só pode ser alterada
    //por ela mesma ou por suas subclasses
    public Cor cor { get; protected set; }
    public int qtdMovimentos { get; protected set; }
    public Tabuleiro tabuleiro { get; protected set; }
    public Peca(Tabuleiro tabuleiro, Cor cor)
    {
      this.posicao = null;
      this.tabuleiro = tabuleiro;
      this.cor = cor;
      this.qtdMovimentos = 0;
    }

    public abstract bool[,] movimentosPossiveis();

    public void incrementarQtdMovimento()
    {
      qtdMovimentos++;
    }

  }
}