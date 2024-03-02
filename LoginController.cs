using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT
{
    public class LoginController
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem;

        public LoginController()
        {
        }

        public string retornaNomeFuncional(string numPol)
        {           

            int numPolCast = Int32.Parse(numPol);

            try
            {
                string nomeFuncional = null;

                using (var cmd = new SqlCommand("SELECT Nome_Funcional FROM Militares WHERE Numero_Policia = @numPol", conexao.conectar()))
                {
                    cmd.Parameters.AddWithValue("@numPol", numPolCast);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            nomeFuncional = reader["Nome_Funcional"].ToString();
                        }
                    }
                }

                conexao.desconectar();

                return nomeFuncional;
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao consultar o militar " + numPolCast;
            }
            return "ERRO";
        }
    }
}
