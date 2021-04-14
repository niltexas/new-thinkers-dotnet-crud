using DotNetCrud.Entities;
using JogoCrud.DTO.AdicionarJogo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JogoCrud.Repositorios
{
    public interface IRepositorioJogo
    {
        public int Add(Jogo request);
        public void Deletar(int id);
    }
}
