using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDI_Evaluation
{
    public class Posicao
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }

        public Posicao(int Lin, int Col)
        {
            Linha = Lin;
            Coluna = Col;
        }
    }
}
