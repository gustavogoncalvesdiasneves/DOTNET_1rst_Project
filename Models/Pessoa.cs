using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet_1RST_Project.Models
{
    public class Pessoa {
        public string? Nome { get; set; }
        public string? Sobrenome { get; set; }
        public int? Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} {Sobrenome}, e tenho {Idade} Anos.");
        }
    }
}