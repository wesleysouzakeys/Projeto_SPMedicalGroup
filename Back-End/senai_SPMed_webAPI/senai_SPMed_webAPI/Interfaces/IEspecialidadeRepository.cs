using senai_SPMed_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_SPMed_webAPI.Interfaces
{
    interface IEspecialidadeRepository
    {
        void Cadastrar(Especialidade novaEspecialidade);

        List<Especialidade> ListarTodos();

        Especialidade BuscarPorId(int idEspecialidade);

        void Atualizar(int idEspecialidade, Especialidade especialidadeAtualizada);

        void Deletar(int idEspecialidade);
    }
}
