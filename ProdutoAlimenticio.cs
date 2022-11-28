using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Katia
{
    public class ProdutoAlimenticio : Fornecedor
    {
        public int AlimenticioId { get; set; }

        public float Medida { get; set; }

        public string Tipo { get; set; }

        public int ProdutoId { get; set; }
    }
}
