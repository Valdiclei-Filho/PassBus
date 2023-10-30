using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passagem
{
    public class Cliente
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cpf { get; set; }

        public Cliente(string nome, int idade, string cpf)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Idade = idade;
            Cpf = cpf;
        }
    }
}
