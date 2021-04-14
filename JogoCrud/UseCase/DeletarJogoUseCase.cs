using JogoCrud.DTO.DeletarJogo;
using JogoCrud.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JogoCrud.UseCase
{
    public class DeletarJogoUseCase : IDeletarJogoUseCase
    {
        private readonly IRepositorioJogo _repositorioJogo;

        public DeletarJogoUseCase(IRepositorioJogo repositorioJogo)
        {
            _repositorioJogo = repositorioJogo;
        }

        public DeletarJogoResponse Executar(DeletarJogoRequest request)
        {
            var response = new DeletarJogoResponse();
            try
            {
                
                _repositorioJogo.Deletar(request.id);
                response.msg = "Jogo deletado com sucesso";
                return response;
            }
            catch
            {
                response.msg = "Falha ao tentar deletar o jogo";
                return response;
            }
           
        }
    }
}
