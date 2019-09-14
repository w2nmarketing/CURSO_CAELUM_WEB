using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{

    //[Table("tbl_post")]
    public class Post
    {

        //[Column("id")]
        public int Id { get; set; }

        public string Categoria { get; set; }
        public string Titulo { get; set; }
        public string Resumo { get; set; }

        public Post() { }

        //public Post(string categoria, string titulo)
        //{
        //    this.Categoria = categoria;
        //    this.Titulo = titulo;
        //}

        //public Post(string categoria, string titulo, string resumo)
        //{
        //    this.Categoria = categoria;
        //    this.Titulo = titulo;
        //    this.Resumo = resumo;
        //}

    }
}
