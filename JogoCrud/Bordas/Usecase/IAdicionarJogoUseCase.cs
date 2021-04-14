using JogoCrud.DTO.AdicionarJogo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JogoCrud.UseCase
{
    public interface IAdicionarJogoUseCase
    {
        AdicionarJogoResponse Executar(AdicionarJogoRequest request);

    }
}
