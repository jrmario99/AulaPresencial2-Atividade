using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeAula2.Models
{
    public class Casos
    {

        [Key]
        public int CasosId { get; set; }
        public string Sigla { get; set; }
        public string Estado { get; set; }
        public int TotalCasos { get; set; }
        public int mortes { get; set; }
        public int suspeitos { get; set; }
        public int recuperados { get; set; }
        public DateTime Data { get; set; }


    }
}
