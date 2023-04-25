using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Win_Banco02
{
    public class ClassBD
    {
        string conexao = "server = localhost; " +
                        "user id = root; " +
                        "password=master;" +
                        "database=produto;";
        private MySqlConnection AbreBanco()
        {
            MySqlConnection ocon = new MySqlConnection();
            ocon.ConnectionString = this.conexao;
            ocon.Open();
            return ocon;
        }

        private void FechaBanco(MySqlConnection ocon)
        {
            if (ocon.State == ConnectionState.Open)
            {
                ocon.Close();
            }
        }
        public MySqlDataReader ProcedureRetornaDataSet(int Codigo)
        {
            MySqlConnection ocon = new MySqlConnection();
            try
            {
                ocon = AbreBanco();
                MySqlCommand cmdComando = new MySqlCommand();
                cmdComando.CommandType = CommandType.StoredProcedure;
                cmdComando.CommandText = "Pesquisar_Produto";
                cmdComando.Parameters.AddWithValue("@cod", Codigo);
                cmdComando.Connection = ocon;
                return cmdComando.ExecuteReader();
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }

    }
}
