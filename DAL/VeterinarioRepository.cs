using ENTITY;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VeterinarioRepository : BaseRepository<Veterinario>
    {
        public VeterinarioRepository(string nombreArchivo) : base(nombreArchivo)
        {
        }

        public override IList<Veterinario> Consultar()
        {
            try
            {
                StreamReader lector = new StreamReader(ruta);
                List<Veterinario> lista = new List<Veterinario>();

                while (!lector.EndOfStream)
                {

                    lista.Add(Mappear(lector.ReadLine()));
                }
                lector.Close();
               
                return lista;
            }
            catch (Exception)
            {

                return null;
            }
        }

        private Veterinario Mappear(string linea)
        {
            Veterinario veterinario = new Veterinario();

            var aux = linea.Split(';');

            veterinario.Id = int.Parse(aux[0]);
            veterinario.Nombre = aux[1];
            veterinario.Telefono = aux[2];

            return veterinario;
        }

        public override Veterinario ObtenerProId(int id)
        {
            return Consultar().FirstOrDefault<Veterinario>(x => x.Id == id);
        }
    }
}
