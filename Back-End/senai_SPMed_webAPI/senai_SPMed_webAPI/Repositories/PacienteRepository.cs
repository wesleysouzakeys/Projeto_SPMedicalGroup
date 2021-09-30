using senai_SPMed_webAPI.Contexts;
using senai_SPMed_webAPI.Domains;
using senai_SPMed_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_SPMed_webAPI.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        SpMedContext ctx = new SpMedContext(); 
        public void Atualizar(int idPaciente, Paciente pacienteAtualizado)
        {
            Paciente pacienteBuscado = ctx.Pacientes.Find(idPaciente);
            DateTime dataNula = Convert.ToDateTime("01/01/0001");

            if (pacienteAtualizado.IdUsuario != 0 && pacienteAtualizado.DataNascimento != dataNula && pacienteAtualizado.Telefone != null && pacienteAtualizado.Rg != null && pacienteAtualizado.Cpf != null && pacienteAtualizado.Endereco != null)
            {
                pacienteAtualizado.DataNascimento = pacienteBuscado.DataNascimento;
                pacienteAtualizado.Telefone = pacienteBuscado.Telefone;
                pacienteAtualizado.Rg = pacienteBuscado.Rg;
                pacienteAtualizado.Cpf = pacienteBuscado.Cpf;
                pacienteAtualizado.Endereco = pacienteBuscado.Endereco;

                ctx.Pacientes.Update(pacienteBuscado);

                ctx.SaveChanges();
            }
        }

        public Paciente BuscarPorId(int idPaciente)
        {
            return ctx.Pacientes.Find(idPaciente);
        }

        public void Cadastrar(Paciente novoPaciente)
        {
            ctx.Pacientes.Add(novoPaciente);

            ctx.SaveChanges();
        }

        public void Deletar(int idPaciente)
        {
            Paciente paciente = ctx.Pacientes.Find(idPaciente);

            ctx.Pacientes.Remove(paciente);

            ctx.SaveChanges();
        }

        public List<Paciente> ListarTodos()
        {
            return ctx.Pacientes.ToList();
        }
    }
}
