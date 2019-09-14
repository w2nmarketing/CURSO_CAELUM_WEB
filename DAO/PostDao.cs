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

            using (SqlConnection conexao = ConnectionFactory.CriaConexao())
            {

                SqlCommand cmd = conexao.CreateCommand();
                cmd.CommandText = "SELECT * FROM Post;";
                SqlDataReader leitor = cmd.ExecuteReader();

                while (leitor.Read())
                {

                    lista_Posts.Add(new Post(leitor["Categoria"].ToString(), leitor["Titulo"].ToString()) { Resumo = leitor["Resumo"].ToString() });

                }

            }

            return lista_Posts;

        }

        public void Adicionar(Post novoPost)
        {

            using (SqlConnection conexao = ConnectionFactory.CriaConexao())
            {

                SqlCommand cmd = conexao.CreateCommand();
                cmd.CommandText = $"INSERT INTO Post (Titulo, Resumo, Categoria) " +
                    $"VALUES (@titulo, @resumo, @categoria);";

                cmd.Parameters.Add(new SqlParameter("titulo", novoPost.Titulo));
                cmd.Parameters.Add(new SqlParameter("resumo", novoPost.Resumo));
                cmd.Parameters.Add(new SqlParameter("categoria", novoPost.Categoria));

                cmd.ExecuteNonQuery();

            }

        }
    }
}
