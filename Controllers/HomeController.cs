using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Blog.DAO;
using Blog.Infra;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            PostDao registros = new PostDao(new BlogContext());

            return View(registros.ListarPostPublicado());

        }
    }
}