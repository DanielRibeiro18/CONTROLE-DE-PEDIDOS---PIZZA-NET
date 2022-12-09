using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudCJ301116X
{
    internal class Conexao
    {
        private readonly SqlConnection con;
        private readonly string DataBase = "crudCJ301116X";
        public Conexao()                            
        {
            string stringConnection = @"Data Source=" + Environment.MachineName +
                @"\SQLEXPRESS;Initial Catalog=" + DataBase + ";Integrated Security=true";

            con = new SqlConnection(stringConnection);
            con.Open();
        }


        public void CloseConnection()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
 
        public SqlConnection ReturnConnection()
        {
            return con;
        }
    }
}
