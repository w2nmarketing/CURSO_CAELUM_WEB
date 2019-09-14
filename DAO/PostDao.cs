using Blog.Infra;
using Blog.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Blog.DAO
{
    public class PostDao
    {

        #region ENTITY

        public List<Post> ListarPost()
        {

            using (var contexto = new BlogContext())
            {

                return contexto.Post.ToList();

            };

        }

        public List<Post> ListarPostCategoria(string categoria)
        {

            using (var contexto = new BlogContext())
            {

                return contexto.Post.Where(c => c.Categoria == categoria).ToList();

            };

        }

        public void Adicionar(Post novoPost)
        {

            using (var contexto = new BlogContext())
            {

                contexto.Post.Add(novoPost);
                contexto.SaveChanges();

            };

        }

        public void Excluir(int id)
        {

            using (var contexto = new BlogContext())
            {

                Post postSelecionado = contexto.Post.Where(c => c.Id == id).FirstOrDefault();

                //Post postSelecionado = contexto.Post.Find(id);

                contexto.Post.Remove(postSelecionado);

                contexto.SaveChanges();

            };

        }

        public Post BuscarId(int id)
        {

            using (var contexto = new BlogContext())
            {

                Post postSelecionado = contexto.Post.Where(c => c.Id == id).FirstOrDefault();

                //Post postSelecionado = contexto.Post.Find(id);

                return postSelecionado; 

            };

        }

        public void Alterar(Post novoPost)
        {

            using (var contexto = new BlogContext())
            {

                contexto.Entry(novoPost).State = EntityState.Modified;
                contexto.SaveChanges();

            };

        }

        #endregion

        #region ADO_NET

        //    public List<Post> ListarPost()
        //    {

        //        List<Post> lista_Posts = new List<Post>();

        //        using (SqlConnection conexao = ConnectionFactory.CriaConexao())
        //        {

        //            SqlCommand cmd = conexao.CreateCommand();
        //            cmd.CommandText = "SELECT * FROM Post;";
        //            SqlDataReader leitor = cmd.ExecuteReader();

        //            while (leitor.Read())
        //            {

        //                lista_Posts.Add(new Post(leitor["Categoria"].ToString(), leitor["Titulo"].ToString()) { Resumo = leitor["Resumo"].ToString() });

        //            }

        //        }

        //        return lista_Posts;

        //    }

        //    public void Adicionar(Post novoPost)
        //{

        //    using (SqlConnection conexao = ConnectionFactory.CriaConexao())
        //    {

        //        SqlCommand cmd = conexao.CreateCommand();
        //        cmd.CommandText = $"INSERT INTO Post (Titulo, Resumo, Categoria) " +
        //            $"VALUES (@titulo, @resumo, @categoria);";

        //        cmd.Parameters.Add(new SqlParameter("titulo", novoPost.Titulo));
        //        cmd.Parameters.Add(new SqlParameter("resumo", novoPost.Resumo));
        //        cmd.Parameters.Add(new SqlParameter("categoria", novoPost.Categoria));

        //        cmd.ExecuteNonQuery();

        //    }

        //}

        #endregion

    }
}
