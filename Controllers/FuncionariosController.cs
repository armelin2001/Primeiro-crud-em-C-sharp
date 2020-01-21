using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Primeiro_crud_em_C_sharp.Database;
using Primeiro_crud_em_C_sharp.Models;
using Primeiro_crud_em_C_sharp.Repository;

namespace Primeiro_crud_em_C_sharp.Controllers
{
    public class FuncionariosController : Controller
    {
        private readonly RepositorioFuncionario fun;

        public FuncionariosController(RepositorioFuncionario funcionario) {
            fun = funcionario;
        }
        public IActionResult Cadastrar()
        {
            
            return View(fun.ListarTodos());
        }
        [HttpPost]
        public IActionResult Salvar(Funcionario funcionario) {
            if (ModelState.IsValid) {
                fun.Adicionar(funcionario);
                return View();
            }
            else {
                return View();
            }
        }
        public IActionResult Deletar() {
            return View();
        }
        public IActionResult Alterar() {
            return View();
        }
        public IActionResult ListarFuncionarios() {
            
            return View(fun.ListarTodos());
        }
    }
}