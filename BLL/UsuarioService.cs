using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace BLL
{
    public class UsuarioService : ICrudLectura<Usuario>, ICrudEscritura<Usuario>
    {
        UsuarioRepository usuarioRepository;
        public UsuarioService()
        {
            usuarioRepository = new UsuarioRepository(Utils.ARC_USUARIO);
        }
        public bool Actualizar(Usuario entidad)
        {
            throw new NotImplementedException();
        }

        public ReadOnlyCollection<Usuario> Consultar()
        {
            var lista = usuarioRepository.Consultar();
            return new ReadOnlyCollection<Usuario>(lista);
        }

        public bool Eliminar(Usuario entidad)
        {
            throw new NotImplementedException();
        }

        public string Guardar(Usuario entidad)
        {
            return usuarioRepository.Guardar(entidad);
        }

        public Usuario ObtenerPorId(int id)
        {
            //validar
            return usuarioRepository.ObtenerPorId(id);
        }
    }
}