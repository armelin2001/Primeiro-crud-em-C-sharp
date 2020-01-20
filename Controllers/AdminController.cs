using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Primeiro_crud_em_C_sharp.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
        //[HttpGet("nome/nome:Strign? ")] interrogação deixa que o parametor da rota seja opcional
        [HttpGet("nome")]
        public IActionResult nomes()
        {
            string nome = Request.Query["nome"];
            return Content("Olá " + nome);
        }

        //Para retornar uma view relacionada ao metodo é necessario que voce crie um html com o mesmo nome 
        [HttpGet("view")]
        public IActionResult visualizar()
        {
            ViewData["helloWord"] = false;
            return View();
        }
    }
}