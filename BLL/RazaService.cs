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
    public class RazaService : ICrudEscritura<Raza>, ICrudLectura<Raza>
    {
        RazaRepository razaRepository;
        public RazaService()
        {
            razaRepository = new RazaRepository(Utils.ARC_RAZA);
        }
        public bool Actualizar(Raza entidad)
        {
            throw new NotImplementedException();
        }

        public ReadOnlyCollection<Raza> Consultar()
        {
            var lista = razaRepository.Consultar();
            return new ReadOnlyCollection<Raza>(lista);
        }

        public bool Eliminar(Raza entidad)
        {
            throw new NotImplementedException();
        }

        public string Guardar(Raza entidad)
        {
            var mensaje=razaRepository.Guardar(entidad);
            return mensaje;
        }

        public Raza ObtenerPorId(int id)
        {
            //validar
            return razaRepository.ObtenerPorId(id);
        }
    }
}
