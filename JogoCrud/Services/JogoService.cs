using DotNetCrud.Context;
using DotNetCrud.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace JogoCrud.Services
{
    public class JogoService : IJogoService
    {

        private readonly LocalDbContext _local;


        public JogoService(LocalDbContext local)
        {
            _local = local;

        }

        public bool AdicionarJogo(Jogo jogo)
        {
            _local.jogo.Add(jogo);
            _local.SaveChanges();
            return true;
        }

        public bool AtualizarJogo(Jogo novoJogo)
        {
            _local.jogo.Attach(novoJogo);
            _local.Entry(novoJogo).State = EntityState.Modified;
            _local.SaveChanges();
            return true;
        }

        public bool DeletarJogo(int id)
        {
            var objDeletar = _local.jogo.Where(d => d.id == id).FirstOrDefault();
            _local.jogo.Remove(objDeletar);
            _local.SaveChanges();
            return true;
        }

        public List<Jogo> RetornarListaJogo()
        {
            return _local.jogo.ToList();

        }

        public Jogo RetornarJogoPorId(int id)
        {
            return _local.jogo.Where(d => d.id == id).FirstOrDefault();
        }
    }
}
