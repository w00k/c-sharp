// See https://aka.ms/new-console-template for more information
Console.WriteLine("Super Héroes!");

var vistaLaser = new SuperPoder();
vistaLaser.Nombre = "Vista Laser";
vistaLaser.Descripcion = "Vista de rayos laser";
vistaLaser.Nivel = NivelPoder.NivelCinco;

var superFuerza = new SuperPoder();
superFuerza.Nombre = "Super Fuerza";
superFuerza.Descripcion = "Super Fuerza";
superFuerza.Nivel = NivelPoder.NivelCuatro;

var superVelocidad = new SuperPoder();
superVelocidad.Nombre = "Super Velocidad";
superVelocidad.Descripcion = "Puede hacer cosas muy rapido";
superVelocidad.Nivel = NivelPoder.NivelTres;

var superPoderesSuperman = new List<SuperPoder>
{
    vistaLaser,
    superFuerza,
    superVelocidad
};

var superman = new SuperHeroe();
superman.Id = 1;
superman.Nombre = "Superman";
superman.IdentidadSecreta = "Clark Kent";
superman.Ciudad = "Metrópolis";
superman.SuperPoderes = superPoderesSuperman;//{ "Vista Laser", "Super Aliento frío", "Super Fuerza", "Visión de Rayos X", "Super Velocidad", "Super Oído", "Super Resistencia" };
superman.PuedeVolar = true;

var superMillonario = new SuperPoder();
superMillonario.Nombre = "Super Millonario";
superMillonario.Descripcion = "Capacidad de mover dineros y manejo de recursos para lograr sus objetivos";
superMillonario.Nivel = NivelPoder.NivelCinco;

var superInteligente = new SuperPoder();
superInteligente.Nombre = "Super Inteligente";
superInteligente.Descripcion = "Capacidad para resolver problemas y anteponerse a situaciones";
superInteligente.Nivel = NivelPoder.NivelCuatro;

var superPoderesBatman = new List<SuperPoder>
{
    superInteligente,
    superMillonario
};


var batman = new SuperHeroe();
batman.Id = 2;
batman.Nombre = "Batman";
batman.IdentidadSecreta = "Bruce Wayne";
batman.Ciudad = "Ciudad Gotica";
batman.SuperPoderes = superPoderesBatman;
batman.PuedeVolar = false;

var superVelocidadFlash = new SuperPoder();
superVelocidadFlash.Nombre = "Super Velocidad";
superVelocidadFlash.Descripcion = "La velocidad mas rapida del Universo DC y Marvel!!!";
superVelocidadFlash.Nivel = NivelPoder.NivelCinco;

var superPoderesFlash = new List<SuperPoder>
{
    superVelocidadFlash
};


var flash = new SuperHeroe();
flash.Id = 3;
flash.Nombre = "The Flash";
flash.IdentidadSecreta = "Barry Allend";
flash.Ciudad = "Central City";
flash.SuperPoderes = superPoderesFlash;
flash.PuedeVolar = false;


var superInteligencia = new SuperPoder();
superInteligencia.Nombre = "Super Inteligencia";
superInteligencia.Descripcion = "Sabiduría de Salomón";
superInteligencia.Nivel = NivelPoder.NivelCuatro;

var superPoderesShazam = new List<SuperPoder>
{
    superInteligencia,
    superFuerza,
    superVelocidad
};

var shazam = new SuperHeroe();
shazam.Id = 4;
shazam.Nombre = "Shazam";
shazam.IdentidadSecreta = "Billy Batson";
shazam.Ciudad = "Fawcett City";
shazam.SuperPoderes = superPoderesShazam; // { "Sabiduría de Salomón", "Fuerza de Hércules", "Resistencia de Atlas", "Poder de Zeus", "Valor de Aquiles", "Velocidad de Mercurio" };
shazam.PuedeVolar = true;

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
}

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

enum NivelPoder
{
    NivelUno,
    NivelDos,
    NivelTres,
    NivelCuatro,
    NivelCinco,
}
