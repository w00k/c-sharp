// See https://aka.ms/new-console-template for more information
Console.WriteLine("Switch Exammple!");

string switchControl = "0";

switch (switchControl)
{
    case "menu":
        Console.WriteLine("Bienvenido al Casino");
        break;
    case "21":
        Console.WriteLine("Black Jack!!!");
        break;
    default: 
        Console.WriteLine("Valor ingresado no válido");
        break;
}