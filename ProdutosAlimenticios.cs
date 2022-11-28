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
    public partial class ProdutosAlimenticios : Form
    {
        public ProdutosAlimenticios()
        {
            InitializeComponent();
        }


        Conexao conexao = new Conexao();

        private void Apagar()
        {
            Txt_Medida.Text = "";
            Txt_Tipo.Text = "";

        }
        private void Btn_Apagar_Click(object sender, EventArgs e)
        {
            conexao.Conectar();

            string sql = "Delete from dbo.ProdutosAlimenticios where AlimenticioId = " + this.Txt_AlimentoId.Text;

            SqlCommand comando = new SqlCommand(sql, conexao.conectar);

            comando.ExecuteNonQuery();

            Txt_AlimentoId.Clear();
            Txt_Medida.Clear();
            Txt_Tipo.Clear();

            conexao.Desconectar();
            MessageBox.Show("Item deletado", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            
            Salvar(); 
            MessageBox.Show("Informações Salvas", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Apagar();
        }

        private void Salvar()
        {
            conexao.Conectar();

            string sql = "insert into dbo.ProdutosAlimenticios (AlimenticioId, Medida, Tipo) values (" + Txt_AlimentoId.Text + ", " + Txt_Medida.Text + ", " + Txt_Tipo.Text + ")";

            SqlCommand comando = new SqlCommand(sql, conexao.conectar);

            comando.ExecuteNonQuery();

            conexao.Desconectar();

          
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
