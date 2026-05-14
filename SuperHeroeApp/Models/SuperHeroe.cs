using System;
using System.Collections.Generic;
using SuperHeroeApp.Interfaces;

namespace SuperHeroeApp.Models
{
    class SuperHeroe : Heroe, ISuperHeroe
    {
        private string _Nombre = "";
        public uint Id { get; set; }
        
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
                return $"{Nombre} ({IdentidadSecreta})";
            }
        }

        public string IdentidadSecreta { get; set; }
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
        
        public override string SalvarLaTierra()
        {
            return $"{NombreEIdentidadSecreta}, ha salvado la tierra!";
        }
    }
}
