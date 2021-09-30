using senai_SPMed_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_SPMed_webAPI.Interfaces
{
    interface IMedicoRepository
    {
        void Cadastrar(Medico novoMedico);

        List<Medico> ListarTodos();

        Medico BuscarPorId(int idMedico);

        void Atualizar(int idMedico, Medico medicoAtualizado);

        void Deletar(int idMedico);
    }
}
