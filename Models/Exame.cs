using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RMSLab.Models
{
    public class Exame
    {
        public string Tipo { get; set; }
        public StatusExame Status { get; set; }
        public string Resultado { get; set; }
    }
}