using senai_SPMed_webAPI.Contexts;
using senai_SPMed_webAPI.Domains;
using senai_SPMed_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace senai_SPMed_webAPI.Repositories
{
    public class EspecialidadeRepository : IEspecialidadeRepository
    {
        SpMedContext ctx = new SpMedContext();

        public void Atualizar(int idEspecialidade, Especialidade especialidadeAtualizada)
        {
            Especialidade especialidadeBuscada = ctx.Especialidades.Find(idEspecialidade);

            if (especialidadeAtualizada.Especialidade1 != null)
            {
                especialidadeAtualizada.Especialidade1 = especialidadeBuscada.Especialidade1;

                ctx.Especialidades.Update(especialidadeBuscada);

                ctx.SaveChanges();
            }
        }

        public Especialidade BuscarPorId(int idEspecialidade)
        {
            return ctx.Especialidades.FirstOrDefault(u => u.IdEspecialidade == idEspecialidade);
        }

        public void Cadastrar(Especialidade novaEspecialidade)
        {
            ctx.Especialidades.Add(novaEspecialidade);

            ctx.SaveChanges();
        }

        public void Deletar(int idEspecialidade)
        {
            Especialidade especialidade = ctx.Especialidades.Find(idEspecialidade);

            ctx.Especialidades.Remove(especialidade);

            ctx.SaveChanges();
        }

        public List<Especialidade> ListarTodos()
        {
            return ctx.Especialidades.ToList();
        }
    }
}
