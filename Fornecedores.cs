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
    public partial class Fornecedores : Form
    {
        public Fornecedores()
        {
            InitializeComponent();
        }

        Fornecedor fornecedor = new Fornecedor();

        Conexao conexao = new Conexao();

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            Salvar();
            MessageBox.Show("Informações Salvas", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Apagar();

        }
        private void Salvar()
        {
            conexao.Conectar();
            string sql = "insert into dbo.Fornecedor (FornecedorId, Cnpj,  EnderecoRua, EnderecoNumero, Email, NomeFantasia, Telefone, InscricaoEstadual) values('" + Txt_IdFornecedor + "', " + Txt_Cnpj.Text + ", '" + Txt_Endereco.Text + "', '" + Txt_EnderecoNumero.Text + "', '" + Txt_Email.Text + "', '" + Txt_NomeFantasia.Text + "', '" + Txt_Telefone.Text + "', '" + Txt_InscricaoEstadual.Text + "')";


            SqlCommand comando = new SqlCommand(sql, conexao.conectar);

            comando.ExecuteNonQuery();

            conexao.Desconectar();
        }

        private void Btn_Apagar_Click(object sender, EventArgs e)
        {
            conexao.Conectar();

            string sql = "Delete from dbo.Fornecedor where FornecedorId = " + this.Txt_IdFornecedor.Text;

            SqlCommand comando = new SqlCommand(sql, conexao.conectar);

            comando.ExecuteNonQuery();

            Txt_Cnpj.Clear();
            Txt_Email.Clear();
            Txt_Endereco.Clear();
            Txt_EnderecoNumero.Clear();
            Txt_IdFornecedor.Clear();
            Txt_InscricaoEstadual.Clear();
            Txt_NomeFantasia.Clear();
            Txt_RazaoSocial.Clear();
            Txt_Telefone.Clear();

            conexao.Desconectar();
            
        }

        private void Apagar()
        {
            Txt_IdFornecedor.Text = "";
            Txt_Cnpj.Text = "";
            Txt_Email.Text = "";
            Txt_Endereco.Text = "";
            Txt_EnderecoNumero.Text = "";
            Txt_InscricaoEstadual.Text = "";
            Txt_NomeFantasia.Text = "";
            Txt_RazaoSocial.Text = "";
            Txt_Telefone.Text = "";
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_CadastrarProduto_Click(object sender, EventArgs e)
        {
            Produtos f = new Produtos();
            f.ShowDialog();
        }

        private void Btn_Pesquisar_Click(object sender, EventArgs e)
        {
            conexao.Conectar();
            //string Cnpj = "'%" + Txt_Cnpj.Text + "%'";
            string sql = "Select * from dbo.Fornecedor where Cnpj = " + this.Txt_Cnpj.Text;

            SqlCommand comando = new SqlCommand(sql, conexao.conectar);

            SqlDataReader leitura = comando.ExecuteReader();

            while (leitura.Read())
            {
                string[] row =
                {
                            leitura.GetString(0),
                            leitura.GetString(1),
                            leitura.GetString(2),
                            leitura.GetString(3),
                            leitura.GetString(4),
                            leitura.GetString(5),
                            leitura.GetString(6),
                            leitura.GetString(7),
                };

                Txt_IdFornecedor.Text = row[0];
                Txt_Cnpj.Text = row[1];
                Txt_RazaoSocial.Text = row[2];
                Txt_EnderecoNumero.Text = row[3];
                Txt_Endereco.Text = row[2];
                Txt_Email.Text = row[4];
                Txt_NomeFantasia.Text = row[5];
                Txt_Telefone.Text = row[6];
                Txt_InscricaoEstadual.Text = row[7];
            }
            conexao.Desconectar();
        }
    }
}
