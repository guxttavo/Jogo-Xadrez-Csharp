namespace jogo_xadrez.Tabuleiro
{
  public class Posicao
  {
    public int linha { get; set; }
    public int coluna { get; set; }
    public Posicao(int linha, int coluna)
    {
      this.linha = linha;
      this.coluna = coluna;
    }
    /*o ToString() é usado para retornar uma representação em formato string do objeto.A classe posição está sobrescrevendo o método "ToString()" da classe base 'Object'
    Sem o uso do Override a implementação personalizada não seria aplicada e o comportamento padrão do método "ToString()" na classe base seria usado em vez disso.*/
    public override string ToString()
    {
      return linha
          + ","
          + coluna;
    }
  }
}