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
        private readonly RepositorioFuncionario pessoa;

        public FuncionariosController(RepositorioFuncionario pessoa) {
            this.pessoa = pessoa;
        }
        public IActionResult Cadastrar()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Salvar(Funcionario funcionario) {
            if (ModelState.IsValid) {
                pessoa.Adicionar(funcionario);
                return Content("Funcionario salvo com sucesso! ");
            }//fazer tratamento de erro no back casso o erro passe no front 
            else {
                return View();
            }
        }
        public IActionResult Deletar() {
            return View();
        }
        public IActionResult Alterar() {

        }
        public IActionResult ListarFuncionarios() {

        }
    }
}