using Domain;
using Infra.Data;
using System;
using System.Collections.Generic;

namespace Services
{
    public class UsuarioService
    {
        private UsuarioRepository usuarioRepository = new UsuarioRepository();
        public IEnumerable<Usuario> GetAll()
        {
            return usuarioRepository.GetAll();
        }

        public Usuario GetById(int id)
        {
            return usuarioRepository.GetById(id);
        }

        public void Create(Usuario usuario)
        {
            usuarioRepository.AddUsuario(usuario);
        }

        public void Update(Usuario usuario)
        {
            usuarioRepository.UpdateUsuario(usuario);
        }

        public void DeleteByID(int id)
        {
            usuarioRepository.DeleteUsuarioById(id);
        }
    }
}
