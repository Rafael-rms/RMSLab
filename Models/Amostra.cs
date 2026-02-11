using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RMSLab.Models
{
    public class Amostra
    {
        public string Codigo { get; set; }
        public Paciente Paciente { get; set; }
        public Exame Exame { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}