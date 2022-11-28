using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Exercicio_Katia
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void Btn_Fornecedor_Click(object sender, EventArgs e)
        {
            Fornecedores f = new Fornecedores();
            f.ShowDialog();
        }

        private void Btn_Produto_Click(object sender, EventArgs e)
        {
            Produtos f = new Produtos();
            f.ShowDialog();
        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
