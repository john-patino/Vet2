using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PropietarioService : ICrudEscritura<Propietario>, ICrudLectura<Propietario>
    {
        PropietarioRepository propietarioRepository;
        public PropietarioService()
        {
            propietarioRepository = new PropietarioRepository(Utils.ARC_PROPIETARIO);
        }
        public bool Actualizar(Propietario entidad)
        {
            throw new NotImplementedException();
        }

        public ReadOnlyCollection<Propietario> Consultar()
        {
            var lista= propietarioRepository.Consultar();

            return new ReadOnlyCollection<Propietario>(lista);
        }

        public bool Eliminar(Propietario entidad)
        {
            throw new NotImplementedException();
        }

        public string Guardar(Propietario entidad)
        {
            //validar
            if (ObtenerPorId(entidad.Id)!=null)
            {
                return "ya existe";
            }
            if (entidad.Nombre==string.Empty)
            {
                return "nombre invalido, no puede ser vacio o nulo";
            }
            return propietarioRepository.Guardar(entidad);
        }

        public Propietario ObtenerPorId(int id)
        {
            return propietarioRepository.ObtenerPorId(id);
        }
    }
}
