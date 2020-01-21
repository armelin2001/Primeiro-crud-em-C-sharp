using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Primeiro_crud_em_C_sharp.Models {
    public class Funcionario {
        //para podermos mapear um  atributo para o entity é necessario que o mesmo tenha a primeira letra maiuscula e seja declarado como public 
        public int Id { get; set;}
        public string Nome { get; set;}
        public float Salario { get; set;}
         
    }
}
