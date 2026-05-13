namespace SuperHeroeApp.Models
{
    internal abstract class Heroe
    {
        public abstract string Nombre { get; set; }
        public abstract string SalvarElMundo();

        public virtual string SalvarLaTierra() 
        {
            return $"{Nombre}, ha salvado la tierra!";
        }
    }
}