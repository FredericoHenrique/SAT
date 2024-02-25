using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();
    
        public Conexao()
        {
            con.ConnectionString = "Data Source = LEGION5I\\SQLEXPRESS; Initial Catalog = test; Integrated Security = True; Encrypt = False";
        }

        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            return con;
        }

        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    
    
    }
}
