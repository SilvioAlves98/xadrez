using tabuleiro;

namespace JXadrez
{
     class Rei : peca
    {
        public Rei(Tabuleiro tab, Cor cor): base(tab,cor){
        }

        public override string ToString()
        {
            return "R";
        }
    }
}