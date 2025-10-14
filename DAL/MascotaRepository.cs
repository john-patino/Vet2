using ENTITY;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MascotaRepository : BaseRepository<Mascota>
    {
        RazaRepository razaRepository = new RazaRepository(Utils.ARC_RAZA);
        public MascotaRepository(string nombreArchivo) : base(nombreArchivo)
        {
        }

        public override IList<Mascota> Consultar()
        {
            IList<Mascota> listaRazas = new List<Mascota>();
            try
            {
                StreamReader lector = new StreamReader(ruta);
                while (!lector.EndOfStream)
                {
                    var linea = lector.ReadLine();
                    listaRazas.Add(MapearMascota(linea));
                }
                lector.Close();
                return listaRazas;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private Mascota MapearMascota(string linea)
        {
            Mascota mascota = new Mascota();
            mascota.Id = int.Parse(linea.Split(';')[0]);
            mascota.Nombre = linea.Split(';')[1];
            var idRaza = int.Parse(linea.Split(';')[3]);
            var raza = razaRepository.ObtenerPorId(idRaza);
            mascota.AsignarRaza(raza);
            return mascota;
        }

        public override Mascota ObtenerPorId(int id)
        {
            return Consultar().FirstOrDefault<Mascota>(x => x.Id == id);
        }
    }
}
