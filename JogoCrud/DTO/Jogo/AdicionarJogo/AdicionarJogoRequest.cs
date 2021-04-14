using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JogoCrud.DTO.AdicionarJogo
{
    public class AdicionarJogoRequest
    {
        public string nome { get; set; }

        public string genero { get; set; }

        public string desenvolvedora { get; set; }

        public string console { get; set; }

        public int ano { get; set; }
    }
}
