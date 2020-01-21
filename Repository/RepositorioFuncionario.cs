﻿using Primeiro_crud_em_C_sharp.Database;
using Primeiro_crud_em_C_sharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Primeiro_crud_em_C_sharp.Repository {
    public class RepositorioFuncionario {
        private readonly ApplicationDBContext dataBase;//readonly serve pra proteger o atributo, ou seja o mesmo so pode ser mudado dentro do funcionarioControlle ou na sua propira atribuicao 
        
        public RepositorioFuncionario(ApplicationDBContext database) {
            this.dataBase = database;
        }
        public Funcionario Buscar(int id) {
            return dataBase.Funcionarios.FirstOrDefault(fu => fu.Id == id);//referenciando a table Funcionarios do bd 
        }
        public List<Funcionario> Listar() {
            return dataBase.Funcionarios.ToList();
        }
        public void Adicionar(Funcionario funcionario) {
            dataBase.Funcionarios.Add(funcionario);
            dataBase.SaveChanges();
        }
        public void Deletar(int id) {
            var excluirFuncionario = Buscar(id);
            dataBase.Funcionarios.Remove(excluirFuncionario);
            dataBase.SaveChanges();
        }
        public void Editar(int id) {
            var editarFuncionario = Buscar(id);
            dataBase.Funcionarios.Update(editarFuncionario);
            dataBase.SaveChanges();
        }
    }
}
