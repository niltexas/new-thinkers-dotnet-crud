using DotNetCrud.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JogoCrud.Services
{
    public interface IJogoService
    {
        bool AdicionarJogo(Jogo jogo);
        List<Jogo> RetornarListaJogo();

        Jogo RetornarJogoPorId(int id);

        bool AtualizarJogo(Jogo novoJogo);

        bool DeletarJogo(int id);
    }
}