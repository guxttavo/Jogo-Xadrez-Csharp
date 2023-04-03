using jogo_xadrez.Tabuleiro;

namespace xadrez
{
  class Rei : Peca
  {
    /*-Base é responsável por mandar os parâmetros da classe derivada para classe base
      -Isso é importante pois está garantindo que o construtor da classe base seja inicializado
       primeiro que o construtor da classe derivada
      -Se a classe base não for inicializada primeiro, a classse derivada pode acbar em um estado
       inconsistente ou com membros não inicializados
    */
    public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
    {
    }

    public override string ToString()
    {
      return "R";
    }
  }
}