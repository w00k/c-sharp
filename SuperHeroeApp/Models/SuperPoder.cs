using System;
using System.Collections.Generic;

namespace SuperHeroeApp.Models
{
    class SuperPoder
    {
        public string Nombre;
        public string Descripcion;
        public NivelPoder Nivel;
        public SuperPoder()
        {
            Nombre = "";
            Descripcion = "";
            Nivel = NivelPoder.NivelUno;
        }
    }
}