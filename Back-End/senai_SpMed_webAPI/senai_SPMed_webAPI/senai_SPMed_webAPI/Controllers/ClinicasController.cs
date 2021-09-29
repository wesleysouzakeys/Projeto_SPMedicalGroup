using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using senai_SPMed_webAPI.Domains;
using senai_SPMed_webAPI.Interfaces;
using senai_SPMed_webAPI.Repositories;

namespace senai_SPMed_webAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ClinicasController : ControllerBase
    {
        private IClinicaRepository _clinicaRepository { get; set; }

        public ClinicasController()
        {
            _clinicaRepository = new ClinicaRepository();
        }

        [HttpGet]
        public IActionResult ListarTodos()
        {
            return Ok(_clinicaRepository.ListarTodos());
        }

        [HttpGet("{idClinica}")]
        public IActionResult BuscarPorId(int idClinica)
        {
            return Ok(_clinicaRepository.BuscarPorId(idClinica));
        }

        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Cadastrar(Clinica novaClinica)
        {
            _clinicaRepository.Cadastrar(novaClinica);

            return StatusCode(201);
        }

        [HttpPut("{idClinica}")]
        public IActionResult Atualizar(int idClinica, Clinica clinicaAtualizada)
        {
            _clinicaRepository.Atualizar(idClinica, clinicaAtualizada);
            return StatusCode(204);
        }

        [HttpDelete("{idClinica}")]
        public IActionResult Deletar(int idClinica)
        {
            _clinicaRepository.Deletar(idClinica);

            return StatusCode(204);
        }
    }
}
