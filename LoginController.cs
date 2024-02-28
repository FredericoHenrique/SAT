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

        public void retornaNomeFuncional(string numPol)
        {           

            int numPolCast = Int32.Parse(numPol);

            cmd.CommandText = "SELECT Nome_Funcional FROM Militares WHERE Numero_Policia = @numPol";

            cmd.Parameters.AddWithValue("@numPol", numPolCast);

            try
            {
                cmd.Connection = conexao.conectar();

                cmd.ExecuteReader();

                conexao.desconectar();

                this.mensagem = "Consultado com sucesso. ";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao cadastrar o militar: " + e;
            }
        }
    }
}
