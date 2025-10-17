using ENTITY;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CitaRepository:BaseRepository<Cita>
    {
        MascotaRepository mascotaRepository = new MascotaRepository(Utils.ARC_MASCOTA);
        VeterinarioRepository veterinarioRepository = new VeterinarioRepository(Utils.ARC_VETERINARIO);
        public CitaRepository(string nombreArchivo):base(nombreArchivo)
        {
            
        }
        public override IList<Cita> Consultar() 
        {
            IList<Cita> lista = new List<Cita>();
            try
            {
                StreamReader sr = new StreamReader(ruta);
                while (!sr.EndOfStream)
                {
                    lista.Add(Mappear(sr.ReadLine()));
                }
                sr.Close();
                return lista;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private Cita Mappear(string linea)
        {
            Cita cita = new Cita();
            cita.Id = Convert.ToInt16( linea.Split(';')[0]);
            cita.Descripcion = linea.Split(';')[1];
            cita.FechaCita = Convert.ToDateTime(linea.Split(';')[2]);//ojo
            cita.Mascota = mascotaRepository.ObtenerPorId(int.Parse(linea.Split(';')[3]));
            cita.Veterinario = veterinarioRepository.ObtenerPorId(int.Parse(linea.Split(';')[4]));
            return cita;
        }

        public override Cita ObtenerPorId(int id)
        {
            return Consultar().FirstOrDefault<Cita>(w => w.Id == id);
        }
    }
}
