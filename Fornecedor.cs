using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Katia
{
    public class Fornecedor
    {
        public int FornecedorId { get; set; }

        public string CNPJ { get; set; }

        public string RazaoSocial { get; set; }

        public string EnderecoRua { get; set; }

        public int EnderecoNumero { get; set; }

        public string Email { get; set; }

        public string NomeFantasia { get; set; }

        public int Telefone { get; set; }

        public string InscricaoEstadual { get; set; }
    }
}
