using Blog.Infra;
using Blog.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Blog.DAO
{
    public class PostDao
    {

        public List<Post> ListarPost()
        {

            List<Post> lista_Posts = new List<Post>();

            using (SqlConnection conexao = ConnectionFactory.CriaConexao()) // SUGAR SINTAXE
            {

                SqlCommand cmd = conexao.CreateCommand();
                cmd.CommandText = "SELECT * FROM Post ORDER BY Categoria DESC;";
                SqlDataReader leitor = cmd.ExecuteReader();

                while (leitor.Read())
                {

                    lista_Posts.Add(new Post(leitor["Categoria"].ToString(), leitor["Titulo"].ToString()) { Resumo = leitor["Resumo"].ToString() });

                }

            }

            return lista_Posts;

        }
    }
}
