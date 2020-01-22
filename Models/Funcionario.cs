using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Primeiro_crud_em_C_sharp.Models {
    public class Funcionario {
        //para podermos mapear um  atributo para o entity é necessario que o mesmo tenha a primeira letra maiuscula e seja declarado como public 
        public int Id { get; set;}
        [Required]
        [MinLength(3,ErrorMessage ="o nome deve ser maior que 3 caracteries")]
        public string Nome { get; set;}
        [Required]
        [Range(0,double.MaxValue,ErrorMessage ="O valor deve ser positivo")]
        public double Salario { get; set;}
         
    }
}
