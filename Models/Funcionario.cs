using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Primeiro_crud_em_C_sharp.Models {
    public class Funcionario {
        int id { get; set;}
        string nome { get; set;}
        float salario { get; set;}
         
    }
}
