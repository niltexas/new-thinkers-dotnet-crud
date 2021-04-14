using DotNetCrud.Entities;
using JogoCrud.DTO.AdicionarJogo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JogoCrud.Bordas.Adapter
{
    public interface IAdicionarJogoAdapter
    {
        public Jogo convertRequestParaJogo(AdicionarJogoRequest request);
    }
}
