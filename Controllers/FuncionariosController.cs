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
    public class FuncionariosController : Controller {
        private readonly RepositorioFuncionario fun;

        public FuncionariosController(RepositorioFuncionario funcionario) {
            fun = funcionario;
        }
        [HttpGet]
        public IActionResult Cadastrar() {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(Funcionario funcionario) {
            if (ModelState.IsValid) {
                fun.Adicionar(funcionario);
                return View();
            }
            else {
                return View();
            }
        }
        public IActionResult Deletar(int id) {
            var funcionario = fun.Buscar(id);
            fun.Excluir(funcionario);
            return View("./Cadastrar");
        }
        [HttpPost]
        public IActionResult Alterar(Funcionario funcionario) {
            if (ModelState.IsValid) {
                fun.Editar(funcionario);
                return View();
            } else {
                return View();
            }
        }
        public IActionResult Alterar(int id) {
            var funcionario = fun.Buscar(id);
            return View(funcionario);
        }
        public IActionResult Detalhes(int id) {
            var funcionarioDetalhe = fun.Buscar(id);
            return View(funcionarioDetalhe);
        }
        [HttpPost]
        public IActionResult Detalhes(Funcionario funcionario) {
            fun.Detalhes(funcionario);
            return View();
        }
        public IActionResult ListarFuncionarios() {
            
            return View(fun.ListarTodos());
        }
    }
}