using JogoCrud.DTO.AtualizarJogo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JogoCrud.UseCase
{
    public interface IAtualizarJogoUseCase
    {
        AtualizarJogoResponse Executar(AtualizarJogoRequest request);
    }
}
