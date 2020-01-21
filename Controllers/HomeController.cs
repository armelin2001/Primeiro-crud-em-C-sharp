using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Primeiro_crud_em_C_sharp.Models;
using Primeiro_crud_em_C_sharp.Repository;


namespace Primeiro_crud_em_C_sharp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RepositorioFuncionario fun;


        public HomeController(ILogger<HomeController> logger, RepositorioFuncionario funcionario)
        {
            _logger = logger;
            fun = funcionario;
        }

        public IActionResult Index()
        {
            
            return View(fun.ListarTodos());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
