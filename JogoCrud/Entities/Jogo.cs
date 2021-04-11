using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DotNetCrud.Entities
{
    public class Jogo
    {
        [Key]
        public int id { get; set; }

        public string nome { get; set; }

        public string genero { get; set; }

        public string desenvolvedora { get; set; }

        public string console { get; set; }

        public int ano { get; set; }

    }
}
