using senai_SPMed_webAPI.Contexts;
using senai_SPMed_webAPI.Domains;
using senai_SPMed_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace senai_SPMed_webAPI.Repositories
{
    public class MedicoRepository : IMedicoRepository
    {
        SpMedContext ctx = new SpMedContext();
        public void Atualizar(int idMedico, Medico medicoAtualizado)
        {
            throw new NotImplementedException();
        }

        public Medico BuscarPorId(int idMedico)
        {
            return ctx.Medicos.Find(idMedico);
        }

        public void Cadastrar(Medico novoMedico)
        {
            ctx.Medicos.Add(novoMedico);

            ctx.SaveChanges();
        }

        public void Deletar(int idMedico)
        {
            Medico medicoBuscado = ctx.Medicos.Find(idMedico);

            ctx.Medicos.Remove(medicoBuscado);

            ctx.SaveChanges();
        }

        public List<Medico> ListarTodos()
        {
            return ctx.Medicos.ToList();
        }
    }
}
