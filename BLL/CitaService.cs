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
    public class CitaService : ICrudEscritura<Cita>, ICrudLectura<Cita>
    {
        CitaRepository citaRepository;
        public CitaService()
        {
            citaRepository = new CitaRepository(Utils.ARC_CITA);
        }
        public bool Actualizar(Cita entidad)
        {
            throw new NotImplementedException();
        }

        public ReadOnlyCollection<Cita> Consultar()
        {
            var lista = citaRepository.Consultar();
            return lista!=null ? new ReadOnlyCollection<Cita>(lista): null;
        }

        public bool Eliminar(Cita entidad)
        {
            throw new NotImplementedException();
        }

        public string Guardar(Cita entidad)
        {
            throw new NotImplementedException();
        }

        public Cita ObtenerPorId(int id)
        {
            return Consultar().FirstOrDefault<Cita>(x => x.Id == id);
        }
    }
}
