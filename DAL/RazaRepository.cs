using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using ENTITY;

namespace DAL
{
    public class RazaRepository : BaseRepository<Raza>
    {
        public RazaRepository(string nombreArchivo) : base(nombreArchivo)
        {
        }

        public override IList<Raza> Consultar()
        {
            IList<Raza> listaRazas = new List<Raza>();
            try
            {
                StreamReader lector = new StreamReader(ruta);
                while (!lector.EndOfStream)
                {
                    var linea = lector.ReadLine();
                    listaRazas.Add(MapearRaza(linea));
                }
                lector.Close();
                return listaRazas;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private Raza MapearRaza(string linea)
        {
            Raza raza = new Raza();
            var aux = linea.Split(';');
            raza.Id = int.Parse(aux[0]);
            raza.Nombre = aux[1];
            return raza;
        }

        public override Raza ObtenerPorId(int id)
        {
            //var lista = Consultar();
            //foreach (var item in lista)
            //{
            //    if (item.Id==id)
            //    {
            //        return item;
            //    }
            //}
            //return null;

            return  Consultar().FirstOrDefault<Raza>(x => x.Id == id);
        }
    }
}