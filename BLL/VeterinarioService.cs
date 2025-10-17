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
    public class VeterinarioService : ICrudEscritura<Veterinario>, ICrudLectura<Veterinario>
    {
        VeterinarioRepository veterinarioRepository;
        public VeterinarioService()
        {
            veterinarioRepository = new VeterinarioRepository(Utils.ARC_VETERINARIO);
        }
        public string Guardar(Veterinario entidad)
        {
            //validaciones
            if (ObtenerPorId(entidad.Id) != null)
            {
                return "ya existe";
            }
            return veterinarioRepository.Guardar(entidad);
        }
        public ReadOnlyCollection<Veterinario> Consultar()
        {
            var lista= veterinarioRepository.Consultar();
            return new ReadOnlyCollection<Veterinario>(lista);
        }

        public Veterinario ObtenerPorId(int id)
        {
            //validar
            return veterinarioRepository.ObtenerPorId(id);
        }
        public bool Actualizar(Veterinario entidad)
        {
            throw new NotImplementedException();
        }       

        public bool Eliminar(Veterinario entidad)
        {
            throw new NotImplementedException();
        }

        
    }
}
