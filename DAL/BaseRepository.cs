using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public  abstract class BaseRepository<T>
    {
        protected string ruta;

        protected BaseRepository(string nombreArchivo)
        {
            this.ruta = nombreArchivo;
        }

        public string Guardar(T entidad)
        {
            StreamWriter sw = new StreamWriter(ruta,true);
            sw.WriteLine(entidad.ToString());
            sw.Close();
            return $"se guardo los datos de la entidad {typeof(T)}";

        }

        public abstract IList<T> Consultar();
        public abstract T ObtenerProId(int id);

    }
}
