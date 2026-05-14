using System;
using SuperHeroeApp.Interfaces;

namespace SuperHeroeApp
{
    internal class ImprimirInfo
    {
        public void ImprimirSuperHeroe(ISuperHeroe superHeroe)
        {
            Console.WriteLine($"Id: {superHeroe.Id}\nNombre: {superHeroe.Nombre}\nIdentidad secreta: {superHeroe.IdentidadSecreta}");
        }
    }
}