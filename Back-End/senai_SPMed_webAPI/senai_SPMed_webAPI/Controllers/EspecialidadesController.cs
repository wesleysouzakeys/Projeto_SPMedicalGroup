using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai_SPMed_webAPI.Domains;
using senai_SPMed_webAPI.Interfaces;
using senai_SPMed_webAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_SPMed_webAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class EspecialidadesController : ControllerBase
    {
        private IEspecialidadeRepository _especialidadeRepository { get; set; }

        public EspecialidadesController()
        {
            _especialidadeRepository = new EspecialidadeRepository();
        }

        [HttpGet]
        public IActionResult ListarTodos()
        {
            return Ok(_especialidadeRepository.ListarTodos());
        }

        [HttpGet("{idEspecialidade}")]
        public IActionResult BuscarPorId(int idEspecialidade)
        {
            return Ok(_especialidadeRepository.BuscarPorId(idEspecialidade));
        }

        [HttpPost]
        public IActionResult Cadastrar(Especialidade novaEspecialidade)
        {
            _especialidadeRepository.Cadastrar(novaEspecialidade);

            return StatusCode(201);
        }

        [HttpPut("{idEspecialidade}")]
        public IActionResult Atualizar(int idEspecialidade, Especialidade especialidadeAtualizada)
        {
            _especialidadeRepository.Atualizar(idEspecialidade, especialidadeAtualizada);
            return StatusCode(204);
        }

        [HttpDelete("{idEspecialidade}")]
        public IActionResult Deletar(int idEspecialidade)
        {
            _especialidadeRepository.Deletar(idEspecialidade);

            return StatusCode(204);
        }
    }
}
