using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Katia
{
    public class Produto
    {
        public int ProdutoId { get; set; }

        public int Codigo { get; set; }

        public string Descricao { get; set; }

        public DateTime Validade { get; set; }

        public float Preco { get; set; }

        public int QtdEstoque { get; set; }

        public int FornecedorId { get; set; }
    }
}
