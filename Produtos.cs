using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_Katia
{
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
        }

        Conexao conexao = new Conexao();
        


        private void Btn_Apagar_Click(object sender, EventArgs e)
        {
            conexao.Conectar();

            string sql = "Delete from dbo.Produto where FornecedorId = " + this.Txt_Codigo.Text;

            SqlCommand comando = new SqlCommand(sql, conexao.conectar);

            comando.ExecuteNonQuery();

            Txt_Codigo.Clear();
            Txt_Descricao.Clear();
            Txt_FornecedorId.Clear();
            Txt_Preco.Clear();
            Txt_ProdutoId.Clear();
            Txt_QtdEstoque.Clear();
            Txt_Validade.Clear();

            conexao.Desconectar();
            MessageBox.Show("Item deletado", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Apagar()
        {
            Txt_Codigo.Text = "";
            Txt_Descricao.Text = "";
            Txt_Preco.Text = "";
            Txt_QtdEstoque.Text = "";
            Txt_Validade.Text = "";
            Txt_ProdutoId.Text = "";
            Txt_FornecedorId.Text = "";
        }

        private void Salvar()
        {
            conexao.Conectar();

            string sql = "insert into dbo.Produto (ProdutoId, Codigo, Descricao, Validade, Preco, QtdEstoque, FornecedorId) values (" + Txt_ProdutoId.Text + ", " + Txt_Codigo.Text + ", " + Txt_Descricao.Text + ", " + Txt_Validade.Text + ", " + Txt_Preco.Text + ", " + Txt_QtdEstoque.Text + ", " + Txt_FornecedorId.Text + ")";

            SqlCommand cmd = new SqlCommand(sql, conexao.conectar);

            cmd.ExecuteNonQuery();

            conexao.Desconectar();

            MessageBox.Show("Informações Salvas", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn_IsAlimenticio_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Este produto é alimentício?", "Mensagem de validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Salvar();

                ProdutosAlimenticios f = new ProdutosAlimenticios();
                f.ShowDialog();

            }
            else
            {
                Salvar();
                MessageBox.Show("Informações Salvas", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Apagar();
            }
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_CadastrarNovaEmpresa_Click(object sender, EventArgs e)
        {
            Fornecedores f = new Fornecedores();
            f.ShowDialog();
        }
    }
}
