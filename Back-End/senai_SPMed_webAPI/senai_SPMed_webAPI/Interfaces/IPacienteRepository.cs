using senai_SPMed_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_SPMed_webAPI.Interfaces
{
    interface IPacienteRepository
    {
        void Cadastrar(Paciente novoPaciente);

        List<Paciente> ListarTodos();

        Paciente BuscarPorId(int idPaciente);

        void Atualizar(int idPaciente, Paciente pacienteAtualizado);

        void Deletar(int idPaciente);
    }
}
