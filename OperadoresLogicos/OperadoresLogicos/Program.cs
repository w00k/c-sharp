// See https://aka.ms/new-console-template for more information
Console.WriteLine("Operadores lógicos!");


bool valor1 = true, valor2 = true, valor3 = true;

//AND
bool resultAnd = valor1 && !valor2 && valor3;
Console.WriteLine($"resultAnd : {resultAnd}");

//OR
bool resultOr = valor1 || !valor2 || valor3;
Console.WriteLine($"resultOr : {resultOr}");