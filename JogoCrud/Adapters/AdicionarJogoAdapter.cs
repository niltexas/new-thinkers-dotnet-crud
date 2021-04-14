using DotNetCrud.Entities;
using JogoCrud.Bordas.Adapter;
using JogoCrud.DTO.AdicionarJogo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JogoCrud.Adapters
{
    public class AdicionarJogoAdapter : IAdicionarJogoAdapter
    {
        public Jogo convertRequestParaJogo(AdicionarJogoRequest request)
        {
            var novoJogo = new Jogo();
            novoJogo.nome = request.nome;
            novoJogo.genero = request.genero;
            novoJogo.desenvolvedora = request.desenvolvedora;
            novoJogo.console = request.console;
            novoJogo.ano = request.ano;
            return novoJogo;

            throw new NotImplementedException();
        }
    }
}
