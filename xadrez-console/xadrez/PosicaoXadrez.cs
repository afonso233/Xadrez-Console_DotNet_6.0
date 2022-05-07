using tabuleiro;
namespace xadrez
{
    class PosicaoXadrez
    {
        public char couluna { get; set; }
        public int linha { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            this.couluna = coluna;
            this.linha = linha;
        }
       
        public Posicao toPosicao()
        {
            return new Posicao(8 - linha, couluna - 'a');
        }
        public override string ToString()
        {
            return "" + couluna + linha;
        }
    }
}
