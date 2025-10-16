using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

namespace ENTITY
{
    public class Usuario : Persona
    {
        public string UsuarioLogin { get; set; }

        public string Credencial { get; set; }

        public override string ToString()
        {
            return $"{Id};{Nombre};{Telefono};{UsuarioLogin};{Credencial}";
        }
    }
}