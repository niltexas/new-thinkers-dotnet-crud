using JogoCrud.DTO.DeletarJogo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JogoCrud.UseCase
{
    public interface IDeletarJogoUseCase
    {
        DeletarJogoResponse Executar(DeletarJogoRequest request);
    }
}
