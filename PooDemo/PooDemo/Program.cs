// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Mouse mouseOne = new Mouse();
mouseOne.Color = "Blanco";
mouseOne.Marca = "Logitech";
mouseOne.CantidadBotones = 5;
mouseOne.Wired = true;

Console.WriteLine($"Mouse One {mouseOne}");

Mouse mouseTwo = new Mouse();
mouseTwo.Color = "Negro";
mouseTwo.Marca = "Roccat";
mouseTwo.CantidadBotones = 3;
mouseTwo.Wired = true;

Console.WriteLine($"Mouse Two {mouseTwo}");


class Mouse
{
    public string Marca;
    public string Color;
    public uint CantidadBotones;
    public bool Wired;
}