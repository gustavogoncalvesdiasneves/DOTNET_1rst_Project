using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet_1RST_Project.Models
{
    public class VarTypes // PascalCase
    {
        public string? Apresentacao { get; set; } // PascalCase
        public int? Quantidade { get; set; } // PascalCase
        public double? Altura { get; set; } // PascalCase
        public decimal? Preco { get; set; } // PascalCase
        public bool? Condicao { get; set; } // PascalCase

        public void Apresentar() // PascalCase
        {
            Console.WriteLine(Apresentacao);
        }
    }
}