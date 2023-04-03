namespace jogo_xadrez.Tabuleiro
{
  public class Peca
  {
    //Uma peça está em alguma posição
    public Posicao posicao { get; set; }
    //A cor pode ser acessada por outras classes mas só pode ser alterada
    //por ela mesma ou por suas subclasses
    public Cor cor { get; protected set; }
    public int qtdMovimentos { get; protected set; }
    public Tabuleiro tab { get; protected set; }
    public Peca(Tabuleiro tab, Cor cor)
    {
      this.posicao = null;
      this.tab = tab;
      this.cor = cor;
      this.qtdMovimentos = 0;
    }

  }
}