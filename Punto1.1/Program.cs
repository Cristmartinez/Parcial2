namespace Punto1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mensaje de  Bienvenida
            Console.WriteLine("Bienvenido al juego Adivina el número!");
            //Creacionde del bucle para que los participantes puedan ingresar varios numeros
            while (true)
            {
                //Declaracion de variables numero de jugadores
                int numJugadores;
                Console.Write("Ingrese el número de jugadores (entre 2 y 4): ");
                numJugadores = int.Parse(Console.ReadLine());

                int valorMin = 0;
                int ValorMax = 0;

                switch (numJugadores)
                {
                    case 2:
                        ValorMax = 50;
                        break;
                    case 3:
                        ValorMax = 100;
                        break;
                    case 4:
                        ValorMax = 200;
                        break;
                    default:
                        Console.WriteLine("Número de jugadores no válido. Intente de nuevo.");
                        continue;
                }

                int numAleatorio = new Random().Next(valorMin, ValorMax + 1);

                Console.WriteLine($"Número aleatorio generado entre {valorMin} y {ValorMax}. ¡Comienza el juego!");

                bool ganadorJuego = false;
                int jugadorActual = 1;

                while (!ganadorJuego)
                {
                    Console.Write($"Jugador {jugadorActual}, ingrese su número: ");
                    int guess = int.Parse(Console.ReadLine());

                    if (guess < numAleatorio)
                    {
                        Console.WriteLine("MAYOR");
                    }
                    else if (guess > numAleatorio)
                    {
                        Console.WriteLine("MENOR");
                    }
                    else
                    {
                        Console.WriteLine("¡HAS GANADO!");
                        ganadorJuego = true;
                    }

                    jugadorActual = (jugadorActual % numJugadores) + 1;
                }

                Console.Write("¿Desea jugar de nuevo? (s/n): ");
                string playAgain = Console.ReadLine().ToLower();

                if (playAgain != "s")
                {
                    break;
                }

                Console.Clear();
            }

            Console.WriteLine("¡Gracias por jugar!");
        }
    }
}


