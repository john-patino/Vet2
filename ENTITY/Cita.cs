using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Cita
    {
        public int Id { get; set; }

        public string Descripcion
        {
            get => default;
            set
            {

            }
        }
        public DateTime FechaCita { get; set; }
        public Mascota Mascota { get; set; }
        public Veterinario Veterinario { get; set; }
        public override string ToString()
        {
            return $"{Id};{Descripcion};{FechaCita.ToString()};{Mascota.Id};{Veterinario.Id}";
        }
    }
}
