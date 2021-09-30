using senai_SPMed_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_SPMed_webAPI.Interfaces
{
    interface ITipoUsuarioRepository
    {
        void Cadastrar(Tipousuario novoTipoUsuario);

        List<Tipousuario> ListarTodos();

        Tipousuario BuscarPorId(int idTipoUsuario);

        void Atualizar(int idTipoUsuario, Tipousuario tipoUsuarioAtualizado);

        void Deletar(int idTipoUsuario);
    }
}
