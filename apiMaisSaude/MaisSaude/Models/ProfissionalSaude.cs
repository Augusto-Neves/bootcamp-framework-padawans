using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaisSaude.Models
{
    public class ProfissionalSaude
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public string BirthDate { get; set; }
        public char Sexo { get; set; }
        public string Ubs { get; set; }
        public string Funcao { get; set; }
        public string Email { get; set; }
        public int Password { get; set; }

    }
}
