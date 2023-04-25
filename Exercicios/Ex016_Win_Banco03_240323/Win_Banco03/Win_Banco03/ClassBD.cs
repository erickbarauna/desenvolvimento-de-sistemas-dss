using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Win_Banco03
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
        public void ExecutaComandoIncluiParam(List<MySqlParameter> colParam)
        {
            MySqlConnection ocon = new MySqlConnection();
            MySqlCommand cmdComando = new MySqlCommand();
            try
            {
                ocon = AbreBanco();
                cmdComando.CommandType = CommandType.StoredProcedure;
                cmdComando.CommandText = "Inclui_Produto";
                cmdComando.Parameters.AddWithValue("@List<MySqlParameter>", colParam);
                cmdComando.Connection = ocon;
                cmdComando.Parameters.AddRange(colParam.ToArray());
                cmdComando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmdComando.Parameters.Clear();
            }
        }
    }
}
