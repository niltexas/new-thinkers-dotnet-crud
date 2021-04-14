using JogoCrud.DTO.RetornarListaJogo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JogoCrud.UseCase
{
    public interface IRetornarListaJogoUseCase
    {
        RetornarListaJogoResponse Executar(RetornarListaJogoRequest request);
    }
}
