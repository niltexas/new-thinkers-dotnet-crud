using JogoCrud.DTO.RetornarJogoPorId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JogoCrud.UseCase
{
    public interface IRetornarJogoPorIdUseCase
    {
        RetornarJogoPorIdResponse Executar(RetornarJogoPorIdRequest request);
    }
}
