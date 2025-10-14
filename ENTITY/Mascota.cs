using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ENTITY
{
    public class Mascota
    {
        public Mascota()
        {
        }

        public Mascota(int id, string nombreMascota)
        {
            Id = id;
            Nombre = nombreMascota;

        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public Raza Raza { get; private set; }
        public void AsignarRaza(Raza raza)
        {
            this.Raza = raza;
        }
        public override string ToString()
        {
            return $"{Id};{Nombre};{Raza.Id}";
        }
    }
}