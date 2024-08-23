using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet_1RST_Project.Models
{
    public class DateTimeUse // PascalCase
    {
        public DateTime? DataHora { get; set; } // PascalCase
        public DateTime? DataHoraGMT0 { get; set; } // PascalCase
        public String? SomenteData { get; set; } // PascalCase
        public String? SomenteHora { get; set; } // PascalCase

        public void DateNow() // PascalCase
        {
            DataHora = DateTime.Now;
            Console.WriteLine($"Data agora é: {DataHora}");
        }
        public void DateGMT0() // PascalCase
        {
            DataHoraGMT0 = DateTime.Now.AddHours(3); // My TimeZone is GMT-3
            Console.WriteLine($"Data GMT-0 é: {DataHoraGMT0}");
        }
        public void OnlyDate() // PascalCase
        {
            SomenteData = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine($"Somente data: {SomenteData}");
        }
        public void OnlyTime() // PascalCase
        {
            SomenteHora = DateTime.Now.ToString("HH:mm:ss");
            Console.WriteLine($"Somente Horas: {SomenteHora}");
        }
    }
}