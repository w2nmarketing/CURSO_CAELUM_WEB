using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Blog.DAO;
using Blog.Infra;
using Blog.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    public class PostController : Controller
    {

        public PostController()
        {
        }

        public IActionResult Index()
        {

            PostDao registros = new PostDao();

            return View(registros.ListarPost());

        }

        public IActionResult Novo()
        {
            return View(new Post());
        }

        [HttpPost]
        public IActionResult Adiciona(Post novoPost)
        {

            //if (string.IsNullOrEmpty(novoPost.Titulo) ||
            //    string.IsNullOrEmpty(novoPost.Categoria) ||
            //    string.IsNullOrEmpty(novoPost.Resumo))
            //{

            //    return View("Novo");

            //}

            if (ModelState.IsValid)
            {

                PostDao dao = new PostDao();

                dao.Adicionar(novoPost);

                return RedirectToAction("Index", "Post");

            }

            return View("Novo", novoPost);

        }

        public IActionResult Categoria([Bind(Prefix = "id")] string nomeCategoria)
        {

            PostDao registros = new PostDao();
        
            return View("Index", registros.ListarPostCategoria(nomeCategoria));
            
        }

        [HttpGet]
        public IActionResult Excluir(int id)
        {

            PostDao dao = new PostDao();

            dao.Excluir(id);

            return RedirectToAction("Index", "Post");

        }

        [HttpGet]
        public IActionResult Visualizar(int id)
        {

            PostDao dao = new PostDao();

            Post postEncontrado = dao.BuscarId(id);

            return View(postEncontrado);

        }

        [HttpPost]
        public IActionResult Alterar(Post novoPost)
        {

            if (ModelState.IsValid)
            {

                PostDao dao = new PostDao();

                dao.Alterar(novoPost);

                return RedirectToAction("Index", "Post");
            }

            return View("Visualizar", novoPost);

        }

        [HttpGet]
        public IActionResult Publicar(int id)
        {
            
            PostDao dao = new PostDao();

            dao.Publicar(id);

            return RedirectToAction("Index", "Post");

        }


    }
}