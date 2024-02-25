using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SAT
{
    public class CadastroController
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem;

        public CadastroController(string numPol, string nomFun) 
        {
            int numPolCast = Int32.Parse(numPol);

            cmd.CommandText = "INSERT INTO Militares (Numero_Policia, Nome_Funcional, Posto_Graduacao, Centro_Escola, Curso_Secao, Turma_Equipe)" +
                "VALUES (@numPol, @nomFun, 'Soldado', 'Academia de Polícia Militar', 'Curso de Formação de Soldados', 'Turma A');";

            cmd.Parameters.AddWithValue("@numPol", numPolCast);
            cmd.Parameters.AddWithValue("@nomFun", nomFun);

            try
            {
                cmd.Connection = conexao.conectar();

                cmd.ExecuteReader();

                conexao.desconectar();

                this.mensagem = "Cadastrado com sucesso";

            }catch (SqlException e)
            {
                this.mensagem = "Erro ao cadastrar o militar: " + e;
            }

        }
    } 
}
