using tabuleiro;

namespace JXadrez
{
     class Torre : peca
    {
        public Torre(Tabuleiro tab, Cor cor): base(tab,cor){
        }

        public override string ToString()
        {
            return "T";
        }
    }
}