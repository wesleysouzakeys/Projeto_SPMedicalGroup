using senai_SPMed_webAPI.Contexts;
using senai_SPMed_webAPI.Domains;
using senai_SPMed_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_SPMed_webAPI.Repositories
{
    public class ClinicaRepository : IClinicaRepository
    {
        SpMedContext ctx = new SpMedContext();
        public void Atualizar(int idClinica, Clinica clinicaAtualizada)
        {
            Clinica clinicaBuscada = ctx.Clinicas.Find(idClinica);

            if (clinicaAtualizada.NomeClinica != null && clinicaAtualizada.Cnpj != null && clinicaAtualizada.RazaoSocial != null && clinicaAtualizada.Endereco != null)
            {
                clinicaAtualizada.NomeClinica = clinicaBuscada.NomeClinica;
                clinicaAtualizada.Cnpj = clinicaBuscada.Cnpj;
                clinicaAtualizada.RazaoSocial = clinicaBuscada.RazaoSocial;
                clinicaAtualizada.Endereco = clinicaBuscada.Endereco;

                ctx.Clinicas.Update(clinicaBuscada);

                ctx.SaveChanges();
            }
        }

        public Clinica BuscarPorId(int idClinica)
        {
            return ctx.Clinicas.FirstOrDefault(c => c.IdClinica == idClinica);
        }

        public void Cadastrar(Clinica novaClinica)
        {
            ctx.Clinicas.Add(novaClinica);

            ctx.SaveChanges();
        }

        public void Deletar(int idClinica)
        {
            Clinica clinica = ctx.Clinicas.Find(idClinica);

            ctx.Clinicas.Remove(clinica);

            ctx.SaveChanges();
        }

        public List<Clinica> ListarTodos()
        {
            return ctx.Clinicas.ToList();
        }
    }
}
