using ENTITY;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UsuarioRepository:BaseRepository<Usuario>
    {
        public UsuarioRepository(string nombreArchivo):base(nombreArchivo)
        {            
        }
        public override IList<Usuario> Consultar()
        {
            try
            {
                IList<Usuario> lista = new List<Usuario>();
                StreamReader sr = new StreamReader(ruta);
                while (!sr.EndOfStream)
                {
                    lista.Add(Mappear(sr.ReadLine()));
                }
                sr.Close();
                return lista;            }
            catch (Exception)
            {
                return null;
            }
        }

        private Usuario Mappear(string linea)
        {
            Usuario usuario = new Usuario();
            usuario.Id = int.Parse(linea.Split(';')[0]);
            usuario.Nombre = linea.Split(';')[1];
            usuario.Telefono = linea.Split(';')[2];
            usuario.UsuarioLogin = linea.Split(';')[3];
            usuario.Credencial = linea.Split(';')[4];
            return usuario;
        }

        public override Usuario ObtenerPorId(int id)
        {
            return Consultar().FirstOrDefault<Usuario>(a => a.Id == id);
        }
    }
}
