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
        public DbSet<Funcionario> Funcionarios { get; set; }//mepando entidade no .net que vai criar uma table com o apelido Funcionarios
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) {

        }
    }
}
