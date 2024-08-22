using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet_1RST_Project.Models
{
    public class Pessoa // PascalCase
    {
        public string? Nome { get; set; } // PascalCase
        public string? Sobrenome { get; set; } // PascalCase
        public int? Idade { get; set; } // PascalCase

        public void Apresentar() // PascalCase
        {
            Console.WriteLine($"Olá, meu nome é {Nome} {Sobrenome}, e tenho {Idade} Anos.");
        }
    }
}