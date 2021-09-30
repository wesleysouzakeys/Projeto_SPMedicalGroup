using senai_SPMed_webAPI.Contexts;
using senai_SPMed_webAPI.Domains;
using senai_SPMed_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_SPMed_webAPI.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
        SpMedContext ctx = new SpMedContext();
        public void Atualizar(int idTipoUsuario, Tipousuario tipoUsuarioAtualizado)
        {
            Tipousuario tipoUsuarioBuscado = ctx.Tipousuarios.Find(idTipoUsuario);

            if (tipoUsuarioAtualizado.TipoUsuario1 != null)
            {
                tipoUsuarioAtualizado.TipoUsuario1 = tipoUsuarioBuscado.TipoUsuario1;

                ctx.Tipousuarios.Update(tipoUsuarioBuscado);

                ctx.SaveChanges();
            }
        }

        public Tipousuario BuscarPorId(int idTipoUsuario)
        {
            return ctx.Tipousuarios.FirstOrDefault(u => u.IdTipoUsuario == idTipoUsuario);
        }

        public void Cadastrar(Tipousuario novoTipoUsuario)
        {
            ctx.Tipousuarios.Add(novoTipoUsuario);

            ctx.SaveChanges();
        }

        public void Deletar(int idTipoUsuario)
        {
            Tipousuario tipoUsuario = ctx.Tipousuarios.Find(idTipoUsuario);

            ctx.Tipousuarios.Remove(tipoUsuario);

            ctx.SaveChanges();
        }

        public List<Tipousuario> ListarTodos()
        {
            return ctx.Tipousuarios.ToList();
        }
    }
}
