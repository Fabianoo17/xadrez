using System;
using System.Collections.Generic;
using System.Text;
using xadrez.app.tabuleiro;

namespace xadrez.app.xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(cor,tab)
        {
                
        }

        public override string ToString()
        {
            return "T";
        }
    }
}
