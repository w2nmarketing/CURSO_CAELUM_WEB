﻿using System;
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
            return View();
        }

        [HttpPost]
        public IActionResult Adiciona(Post novoPost)
        {

            PostDao dao = new PostDao();

            dao.Adicionar(novoPost);

            return RedirectToAction("Index", "Post");

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


    }
}