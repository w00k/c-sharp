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

Random generadorAleatorio = new Random();
int carta = generadorAleatorio.Next(1, 13); // Genera un número entre 1 y 12

Console.WriteLine(carta);

while (carta < 10)
{
    Console.WriteLine($" while - Carta: {carta}");
    carta = generadorAleatorio.Next(1, 13);
}
Console.WriteLine($" while - Carta: {carta}");


do
{
    Console.WriteLine($"do-while - Carta: {carta}");
    carta = generadorAleatorio.Next(1, 13);
} while (carta > 10);

Console.WriteLine($"do-while - Carta: {carta}");

for (int i = 0; i < 20; i++)
{
    Console.WriteLine($"i: {i}");
}