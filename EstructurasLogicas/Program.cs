// See https://aka.ms/new-console-template for more information
Console.WriteLine("Black Jack!");

int totalJugador = 20;
int totalDealer = 20;
int maxTotal = 21;
//int minTotalDealer = 18;
string mensaje = "";

if (totalJugador > maxTotal)
{
    mensaje = $"Perdiste, te pasaste de {maxTotal}";
} else if (totalJugador > totalDealer)
{
    mensaje = "Venciste al Dealer, felicidades!!!";
} else if (totalJugador < totalDealer)
{
    mensaje = "Gana la casa.";
} else
{
    mensaje = "Empate, nadie gana.";
}

Console.WriteLine($"Puntaje \n Jugador {totalJugador} \n Dealer {totalDealer} \n {mensaje}");