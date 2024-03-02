using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace Sistema_Grifo.controle
{
    internal class ConexaoGeral
    {
        private static readonly string connectionString = "Server=localhost;Port=3306;Database=grifo;Uid=root;Pwd=1578;";
        public static MySqlConnection Conexao()
        {
            MySqlConnection conexao = new MySqlConnection(connectionString);

            try
            {
                conexao.Open();
                
                MessageBox.Show("Conexão bem-sucedida!", "Conexão", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                // Você pode executar consultas SQL ou outras operações com o banco de dados aqui
            }
            catch (MySqlException ex)
            {
                
                    MessageBox.Show("Erro ao conectar ao banco de dados: ", "Conexão", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question); 
            }
            finally
            {
                conexao.Close();
            }
            return conexao;
        }
    }
}
