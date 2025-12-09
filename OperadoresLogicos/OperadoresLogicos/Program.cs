// See https://aka.ms/new-console-template for more information
Console.WriteLine("Operadores lógicos!");


bool valor1 = true, valor2 = true, valor3 = true;

//AND
bool resultAnd = valor1 && !valor2 && valor3;
Console.WriteLine($"resultAnd : {resultAnd}");

//OR
bool resultOr = valor1 || !valor2 || valor3;
Console.WriteLine($"resultOr : {resultOr}");

////////////////////////////
//NUMEROS
var (numero1, numero2, numero3) = (1, 2, 3);
Console.WriteLine($"Los valores son {numero1} {numero2} {numero3}");

valor1 = numero1 == numero2;
Console.WriteLine($"la comparación entre {numero1} == {numero2} => {valor1}");

valor1 = numero1 < numero3;
Console.WriteLine($"la comparación entre {numero1} < {numero3} => {valor1}");

valor1 = numero1 >= numero3;
Console.WriteLine($"la comparación entre {numero1} >= {numero3} => {valor1}");

valor1 = numero2 != numero3;
Console.WriteLine($"la comparación entre {numero2} != {numero3} => {valor1}");