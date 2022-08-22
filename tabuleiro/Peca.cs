namespace tabuleiro {
    class peca {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public peca(Posicao posicao, Tabuleiro tab, Cor cor) {
            this.posicao = posicao;
        public peca(Tabuleiro tab, Cor cor) {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.qteMovimentos = 0;
        }
        }
    }
}