using DotNetCrud.Entities;
using JogoCrud.DTO.AdicionarJogo;
using JogoCrud.DTO.DeletarJogo;
using JogoCrud.Services;
using JogoCrud.UseCase;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JogoCrud.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class JogoController : ControllerBase
    {
        private readonly ILogger<JogoController> _logger;
        private readonly IJogoService _jogo;
        private readonly IAdicionarJogoUseCase _adicionarJogoUseCase;
        private readonly IDeletarJogoUseCase _deletarJogoUseCase;

        public JogoController(ILogger<JogoController> logger, IJogoService jogo, IAdicionarJogoUseCase adicionarJogoUseCase, IDeletarJogoUseCase deletarJogoUseCase)
        {
            _logger = logger;
            _jogo = jogo;
            _adicionarJogoUseCase = adicionarJogoUseCase;
            _deletarJogoUseCase = deletarJogoUseCase;
        }


        [HttpGet]
        public IActionResult TodosJogos()
        {
            return Ok(_jogo.RetornarListaJogo());
        }

        [HttpGet("{id}")]

        public IActionResult jogo(int id)
        {
            return Ok(_jogo.RetornarJogoPorId(id));
        }

        [HttpPost]

        public IActionResult jogoAdd([FromBody] AdicionarJogoRequest novoJogo)
        {
            return Ok(_adicionarJogoUseCase.Executar(novoJogo));
        }

        [HttpPut]

        public IActionResult JogoUpdate([FromBody] Jogo novoJogo)
        {
            return Ok(_jogo.AtualizarJogo(novoJogo));
        }

        [HttpDelete("{id}")]
        public IActionResult jogoDelete(int id)
        {
            var request = new DeletarJogoRequest();
            request.id = id;
            return Ok(_deletarJogoUseCase.Executar(request));
        }
    }


}

