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
            Medico medicoBuscado = ctx.Medicos.Find(idMedico);

            if (medicoAtualizado.IdUsuario != 0 && medicoAtualizado.IdEspecialidade != 0 && medicoAtualizado.IdClinica != 0 && medicoAtualizado.Crm != null)
            {
                medicoAtualizado.IdUsuario = medicoBuscado.IdUsuario;
                medicoAtualizado.IdEspecialidade = medicoBuscado.IdEspecialidade;
                medicoAtualizado.IdClinica = medicoBuscado.IdClinica;
                medicoAtualizado.Crm = medicoBuscado.Crm;

                ctx.Medicos.Update(medicoBuscado);

                ctx.SaveChanges();
            }
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
