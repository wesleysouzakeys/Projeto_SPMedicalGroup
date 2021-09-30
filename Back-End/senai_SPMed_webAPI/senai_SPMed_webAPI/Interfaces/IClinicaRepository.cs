using senai_SPMed_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_SPMed_webAPI.Interfaces
{
    interface IClinicaRepository
    {
        void Cadastrar(Clinica novaClinica);

        List<Clinica> ListarTodos();

        Clinica BuscarPorId(int idClinica);

        void Atualizar(int idClinica, Clinica clinicaAtualizada);

        void Deletar(int idClinica);
    }
}
