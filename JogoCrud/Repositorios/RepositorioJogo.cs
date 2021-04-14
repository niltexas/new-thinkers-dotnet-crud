using DotNetCrud.Context;
using DotNetCrud.Entities;
using JogoCrud.DTO.AdicionarJogo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JogoCrud.Repositorios
{
    public class RepositorioJogo : IRepositorioJogo
    {
        private readonly LocalDbContext _local;

        public RepositorioJogo(LocalDbContext local)
        {
            _local = local;
        }

        public int Add(Jogo request)
        {
            _local.jogo.Add(request);
            _local.SaveChanges();
            return request.id;
        }

        public void Deletar(int id)
        {
            var obj = _local.jogo.Where(d => d.id == id).FirstOrDefault();
            _local.jogo.Remove(obj);
        }
    }
}
