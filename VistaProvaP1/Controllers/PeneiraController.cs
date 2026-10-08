using Microsoft.AspNetCore.Mvc;
using VistaProvaP1.Models;
using VistaProvaP1.Repository;

namespace VistaProvaP1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PeneiraController : ControllerBase
    {
        private readonly IPeneiraRepository _repository;

        public PeneiraController(IPeneiraRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("ListarJogadores")]
        public IActionResult ListarJogadores()
        {
            return Ok(_repository.ListarJogadores());
        }

        [HttpGet]
        [Route("ListarAprovados")]
        public IActionResult ListarAprovados()
        {
            return Ok(_repository.ListarAprovados());
        }

        [HttpPost]
        [Route("CadastrarJogador")]
        public IActionResult CadastrarJogador(Jogador jogador)
        {
            var resultado = _repository.ObterJogadorPorCpf(jogador.Cpf);

            if (resultado is null)
            {
                _repository.CadastrarJogador(jogador);
                return Ok("Jogador cadastrado com sucesso");
            }
            return BadRequest("CPF já cadastrado");
        }

        [HttpPost]
        [Route("RegistrarResultado")]
        public IActionResult RegistrarResultado(Resultado resultado)
        {
            var jogador = _repository.ObterJogadorPorCpf(resultado.Cpf);

            if (jogador is null)
            {
                return NotFound("Jogador não encontrado, resultado não pode ser registrado");
            }

            var resultadoExistente = _repository.ObterResultadoPorCpf(resultado.Cpf);

            if (resultadoExistente is not null)
            {
                return BadRequest("Resultado já registrado para esse jogador");
            }
            _repository.RegistrarResultado(resultado);
            return Ok("Resultado registrado com sucesso");
        }
    }
}