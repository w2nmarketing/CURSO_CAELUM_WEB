using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.DAO;
using Blog.Infra;
using Blog.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class PostController : Controller
    {

        private readonly PostDao _dao;

        public PostController(PostDao dao)
        {

            _dao = dao;

        }

        public IActionResult Index()
        {

            return View(_dao.ListarPost());

        }

        #region ADICIONAR_REGISTRO

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


                _dao.Adicionar(novoPost);

                return RedirectToAction("Index", "Post");

            }

            return View("Novo", novoPost);

        }
        #endregion


        public IActionResult Categoria([Bind(Prefix = "id")] string nomeCategoria)
        {
            

            return View("Admin/Index", _dao.ListarPostCategoria(nomeCategoria));

        }

        [HttpGet]
        public IActionResult Excluir(int id)
        {


            _dao.Excluir(id);

            return RedirectToAction("Admin/Index", "Post");

        }

        [HttpGet]
        public IActionResult Visualizar(int id)
        {
            

            Post postEncontrado = _dao.BuscarId(id);

            return View(postEncontrado);

        }

        [HttpPost]
        public IActionResult Alterar(Post novoPost)
        {

            if (ModelState.IsValid)
            {


                _dao.Alterar(novoPost);

                return RedirectToAction("Admin/Index", "Post");
            }

            return View("Visualizar", novoPost);

        }

        [HttpGet]
        public IActionResult Publicar(int id)
        {
            

            _dao.Publicar(id);

            return RedirectToAction("Admin/Index", "Post");

        }


    }
}