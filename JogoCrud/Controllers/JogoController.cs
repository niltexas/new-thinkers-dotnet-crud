using DotNetCrud.Entities;
using JogoCrud.Services;
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

        public JogoController(ILogger<JogoController> logger, IJogoService jogo)
        {
            _logger = logger;
            _jogo = jogo;
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

        public IActionResult jogoAdd([FromBody] Jogo novoJogo)
        {
            return Ok(_jogo.AdicionarJogo(novoJogo));
        }

        [HttpPut]

        public IActionResult JogoUpdate([FromBody] Jogo novoJogo)
        {
            return Ok(_jogo.AtualizarJogo(novoJogo));
        }

        [HttpDelete("{id}")]
        public IActionResult produtoDelete(int id)
        {
            return Ok(_jogo.DeletarJogo(id));
        }
    }


}

