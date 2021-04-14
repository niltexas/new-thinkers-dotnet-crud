using JogoCrud.Bordas.Adapter;
using JogoCrud.DTO.AdicionarJogo;
using JogoCrud.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCrud.Entities;

namespace JogoCrud.UseCase
{
    public class AdicionarJogoUseCase : IAdicionarJogoUseCase
    {

        private readonly IRepositorioJogo _repositorioJogo;
        private readonly IAdicionarJogoAdapter _adapter;

        public AdicionarJogoUseCase(IRepositorioJogo repositorioJogo,
                                    IAdicionarJogoAdapter adapter)
        {
            _repositorioJogo = repositorioJogo;
            _adapter = adapter;
        }

        public AdicionarJogoResponse Executar(AdicionarJogoRequest request)
        {
            var response = new AdicionarJogoResponse();
            
           

            try
            {
                if (request.nome.Length < 20)
                {
                    response.msg = "Erro ao acionar jogo";
                    return response;
                    
                }

                var jogoAdicionar = _adapter.convertRequestParaJogo(request);
                var id = _repositorioJogo.Add(jogoAdicionar);
                response.msg = "Adicionado com sucesso";
                response.id = jogoAdicionar.id;
                return response;
            }

            catch
            {
                response.msg = "Erro ao adicionar o jogo";
                return response;

            }

          

        }
    }
}
