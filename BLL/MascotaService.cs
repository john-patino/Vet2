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
    class MascotaService : ICrudEscritura<Mascota>, ICrudLectura<Mascota>
    {
        MascotaRepository mascotaRepository;
        public MascotaService()
        {
            mascotaRepository = new MascotaRepository(Utils.ARC_MASCOTA);
        }
        public bool Actualizar(Mascota entidad)
        {
            throw new NotImplementedException();
        }

        public ReadOnlyCollection<Mascota> Consultar()
        {
            var lista= mascotaRepository.Consultar();
            return new ReadOnlyCollection<Mascota>(lista);
        }

        public bool Eliminar(Mascota entidad)
        {
            throw new NotImplementedException();
        }

        public string Guardar(Mascota entidad)
        {
            throw new NotImplementedException();
        }

        public Mascota ObtenerPorId(int id)
        {
            return mascotaRepository.Consultar().FirstOrDefault<Mascota>(x => x.Id == id);
        }
    }
}
