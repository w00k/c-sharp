using System;
using System.Collections.Generic;

namespace SuperHeroeApp.Models
{
    class SuperHeroe : Heroe
    {
        private string _Nombre;
        public uint Id;
        
        public override string Nombre { get
            {
                return _Nombre;
            }
            set
            {
                _Nombre = value.Trim();
            } 
        }

        public string NombreEIdentidadSecreta
        {
            get
            {
                return $"{Nombre} - {IdentidadSecreta}";
            }
        }

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
                Console.WriteLine($"{NombreEIdentidadSecreta}, esta usando el super poder {poder.Nombre}");
            }
        }
        
        public override string SalvarElMundo()
        {
            return $"{NombreEIdentidadSecreta}, ha salvado el mundo!";
        }
    }
}
