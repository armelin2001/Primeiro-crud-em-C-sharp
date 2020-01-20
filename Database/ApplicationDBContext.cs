using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Primeiro_crud_em_C_sharp.Models;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Primeiro_crud_em_C_sharp.Database {
    public class ApplicationDBContext : DbContext {
        DbSet<Funcionario> Funcionarios;//mepando entidade no bd vai criar uma table com o apelido Funcionarios
        //faltou n fazer migração
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) {

        }
    }
}
