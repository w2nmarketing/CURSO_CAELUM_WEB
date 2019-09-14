using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class Post
    {

        public int Id { get; set; }
        public string Categoria { get; set; }
        public string Titulo { get; set; }
        public string Resumo { get; set; }

        public Post() { }

        public Post(string categoria, string titulo)
        {
            this.Categoria = categoria;
            this.Titulo = titulo;
        }

        public Post(string categoria, string titulo, string resumo)
        {
            this.Categoria = categoria;
            this.Titulo = titulo;
            this.Resumo = resumo;
        }

    }
}
