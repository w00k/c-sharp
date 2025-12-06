// See https://aka.ms/new-console-template for more information


//Programa que calcula el área de un rectángulo 

using System.IO.Pipes;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;

Double ladoA, ladoB, resultado; 

Console.WriteLine("Calcula el lado de un rectángulo");

Console.WriteLine("ingresa el lado A");
ladoA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("ingresa el lado B");
ladoB = Convert.ToDouble(Console.ReadLine());

resultado = ladoA * ladoB;

Console.WriteLine("el área es " + resultado);
// Console.WriteLine($"el área es {resultado}");

//variable implícito
var variable = 15;
Console.WriteLine($"vatiable tiene valor {variable}");

Console.WriteLine("Vamos a calcular el área de un círculo");
// pi * area * area 
Double radio, radioCirculo; //las variables comienzan con minúsculas y camelcase
const Double Pi = 3.14; // o Math.PI las constantes siempre inician con Mayúscula y camelcase

Console.WriteLine("Ingrese el radio del círculo");
radio = Convert.ToDouble(Console.ReadLine());

radioCirculo = radio * radio * Pi;

Console.WriteLine($"El área del circulo es : {radioCirculo}");
