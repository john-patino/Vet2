using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Raza
    {
        public Raza()
        {

        }
        public Raza(int id, string nombreRaza)
        {
            Id = id;
            Nombre = nombreRaza;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        
        public override string ToString()
        {
            return $"{Id};{Nombre}";
        }
    }
}
