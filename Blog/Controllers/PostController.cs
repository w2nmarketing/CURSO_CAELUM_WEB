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

            registros.ListarPost();

            return View(registros.ListarPost());

        }

        public IActionResult Novo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Adiciona(Post novoPost)
        {

            return View();

            //this.Lista_Posts.Add(novoPost);

            //return View("Index", this.Lista_Posts);

        }

    }
}