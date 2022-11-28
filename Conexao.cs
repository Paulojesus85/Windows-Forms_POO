using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Katia
{
    public class Conexao
    {
        public SqlConnection conectar = new SqlConnection();

        public void Conectar()
        {
            if (conectar.State == System.Data.ConnectionState.Closed)
            {
                conectar.ConnectionString = "Data Source=desktop-xxxxxxxx\\sqlexpress;Initial Catalog=PooUnifaat;Integrated Security=True";
                conectar.Open();
            }
        }

        public void Desconectar()
        {
            if(conectar.State == System.Data.ConnectionState.Open)
            {
                conectar.Close();
            }
        }
        public int ExecSql(string sql)
        {
            int nlinhas;
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandText = sql;
                comando.Connection = conectar;
                nlinhas = comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex);
                nlinhas = 0;
            }
            return nlinhas;
        }
        public int ExecEscalar(string sql)
        {
            int conta = 0;
            try
            {
                SqlCommand SqlServerCommand = new SqlCommand();
                SqlServerCommand.CommandText = sql;
                SqlServerCommand.Connection = conectar;
                conta = (int)SqlServerCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex);
            }
            return conta;

        }
    }
}
