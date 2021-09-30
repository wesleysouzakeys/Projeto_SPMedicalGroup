using senai_SPMed_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_SPMed_webAPI.Interfaces
{
    interface IConsultaRepository
    {
        void Cadastrar(Consulta novaConsulta);

        List<Consulta> ListarTodos();

        Consulta BuscarPorId(int idConsulta);

        void Atualizar(int idConsulta, Consulta consultaAtualizada);

        void Deletar(int idConsulta);
    }
}
