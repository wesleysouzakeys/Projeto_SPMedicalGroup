using senai_SPMed_webAPI.Contexts;
using senai_SPMed_webAPI.Domains;
using senai_SPMed_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_SPMed_webAPI.Repositories
{
    public class ConsultaRepository : IConsultaRepository
    {
        SpMedContext ctx = new SpMedContext();
        public void Atualizar(int idConsulta, Consulta consultaAtualizada)
        {
            Consulta consultaBuscada = ctx.Consultas.Find(idConsulta);
            DateTime dataNula = Convert.ToDateTime("01/01/0001");

            if (consultaAtualizada.IdConsulta != 0 && consultaAtualizada.IdMedico != 0 && consultaAtualizada.DataConsulta != dataNula && consultaAtualizada.Situacao != null)
            {
                consultaAtualizada.IdConsulta = consultaBuscada.IdConsulta;
                consultaAtualizada.IdMedico = consultaBuscada.IdMedico;
                consultaAtualizada.DataConsulta = consultaBuscada.DataConsulta;
                consultaAtualizada.Situacao = consultaBuscada.Situacao;

                ctx.Consultas.Update(consultaBuscada);

                ctx.SaveChanges();
            }
        }

        public Consulta BuscarPorId(int idConsulta)
        {
            return ctx.Consultas.Find(idConsulta);
        }

        public void Cadastrar(Consulta novaConsulta)
        {
            ctx.Consultas.Add(novaConsulta);

            ctx.SaveChanges();
        }

        public void Deletar(int idConsulta)
        {
            Consulta consulta = ctx.Consultas.Find(idConsulta);

            ctx.Consultas.Remove(consulta);

            ctx.SaveChanges();
        }

        public List<Consulta> ListarTodos()
        {
            return ctx.Consultas.ToList();
        }
    }
}
