using senai_SPMed_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_SPMed_webAPI.Interfaces
{
    interface IUsuarioRepository
    {
        void Cadastrar(Usuario novoUsuario);

        List<Usuario> ListarTodos();

        Usuario BuscarPorId(int idUsuario);

        void Atualizar(int idUsuario, Usuario usuarioAtualizado);

        void Deletar(int idUsuario);

        Usuario Login(string email, string senha);
    }
}
