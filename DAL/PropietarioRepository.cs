using ENTITY;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DAL
{
    public class PropietarioRepository : BaseRepository<Propietario>
    {
        public PropietarioRepository(string nombreArchivo) : base(nombreArchivo)
        {
        }

        public override IList<Propietario> Consultar()
        {
            try
            {
                StreamReader lector = new StreamReader(ruta);
                List<Propietario> lista = new List<Propietario>();

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

        private Propietario Mappear(string linea)
        {
            Propietario propietario = new Propietario();

            var aux = linea.Split(';');

            propietario.Id = int.Parse(aux[0]);
            propietario.Nombre = aux[1];
            propietario.Telefono = aux[2];

            return propietario;
        }

        public override Propietario ObtenerPorId(int id)
        {
            return Consultar().FirstOrDefault<Propietario>(x => x.Id == id);
        }
    }
}