using System;
using System.Collections.Generic;

namespace SuperHeroeApp.Models
{
    class SuperHeroe
    {
        public uint Id;
        public string Nombre;
        public string IdentidadSecreta;
        public string Ciudad;
        public List<SuperPoder> SuperPoderes;
        public bool PuedeVolar;

        public SuperHeroe()
        {
            Id = 1;
            Nombre = "";
            IdentidadSecreta = "";
            Ciudad = "";
            PuedeVolar = false;
            SuperPoderes = new List<SuperPoder>();
        }

        public void UsarSuperPoder()
        {
            foreach (var poder in this.SuperPoderes)
            {
                Console.WriteLine($"{Nombre} esta usando el super poder {poder.Nombre}");
            }
        }
    }
}
