using System;
using System.Collections.Generic;

namespace SuperHeroeApp.Interfaces
{
    internal interface ISuperHeroe
    {
        uint Id { get; set; }
        string Nombre { get; set; }
        string IdentidadSecreta { get; set; }
    }
    
}