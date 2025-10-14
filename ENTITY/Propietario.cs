using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ENTITY
{
    public class Propietario : Persona
    {
        public override string ToString()
        {
            return $"{Id};{Nombre};{Telefono}";
        }
    }
}