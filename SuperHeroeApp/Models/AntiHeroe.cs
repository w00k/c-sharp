using System;

namespace SuperHeroeApp.Models
{
    internal class AntiHeroe : SuperHeroe
    {
        public string RealizarAccionAntiHeroe(string accion)
        {
            return $"El AntiHeroe {NombreEIdentidadSecreta} ha realizado {accion}";
        }
    }
}