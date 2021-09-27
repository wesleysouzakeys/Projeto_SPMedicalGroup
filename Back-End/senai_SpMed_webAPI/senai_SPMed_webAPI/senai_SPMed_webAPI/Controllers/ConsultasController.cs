using Microsoft.AspNetCore.Mvc;
using senai_SPMed_webAPI.Domains;
using senai_SPMed_webAPI.Interfaces;
using senai_SPMed_webAPI.Repositories;

namespace senai_SPMed_webAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultasController : ControllerBase
    {
        private IConsultaRepository _consultaRepository { get; set; }

        public ConsultasController()
        {
            _consultaRepository = new ConsultaRepository();
        }

        [HttpGet]
        public IActionResult ListarTodos()
        {
            return Ok(_consultaRepository.ListarTodos());
        }

        [HttpGet("{idConsulta}")]
        public IActionResult BuscarPorId(int idConsulta)
        {
            return Ok(_consultaRepository.BuscarPorId(idConsulta));
        }

        [HttpPost]
        public IActionResult Cadastrar(Consulta novaConsulta)
        {
            _consultaRepository.Cadastrar(novaConsulta);

            return StatusCode(201);
        }

        [HttpPut("{idConsulta}")]
        public IActionResult Atualizar(int idConsulta, Consulta consultaAtualizada)
        {
            _consultaRepository.Atualizar(idConsulta, consultaAtualizada);
            return StatusCode(204);
        }

        [HttpDelete("{idConsulta}")]
        public IActionResult Deletar(int idConsulta)
        {
            _consultaRepository.Deletar(idConsulta);

            return StatusCode(204);
        }
    }
}
