namespace Punto1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al juego Adivina el número!");

            bool jugarDeNuevo = true;

            while (jugarDeNuevo)
            {
                Console.Write("Ingrese el número de jugadores (entre 2 y 4): ");
                int numPlayers = int.Parse(Console.ReadLine());

                int minValue = 0;
                int maxValue = 0;

                switch (numPlayers)
                {
                    case 2:
                        maxValue = 50;
                        break;
                    case 3:
                        maxValue = 100;
                        break;
                    case 4:
                        maxValue = 200;
                        break;
                    default:
                        Console.WriteLine("Número de jugadores no válido. Intente de nuevo.");
                        continue;
                }

                int targetNumber = new Random().Next(minValue, maxValue + 1);

                Console.WriteLine($"Número aleatorio generado entre {minValue} y {maxValue}. ¡Comienza el juego!");

                bool gameWon = false;
                int currentPlayer = 1;

                while (!gameWon)
                {
                    Console.Write($"Jugador {currentPlayer}, ingrese su número: ");
                    int guess = int.Parse(Console.ReadLine());

                    if (guess < targetNumber)
                    {
                        Console.WriteLine("MAYOR");
                    }
                    else if (guess > targetNumber)
                    {
                        Console.WriteLine("MENOR");
                    }
                    else
                    {
                        Console.WriteLine("¡HAS GANADO!");
                        gameWon = true;
                    }

                    currentPlayer = (currentPlayer % numPlayers) + 1;
                }

                Console.Write("¿Desea jugar de nuevo? (s/n): ");
                string respuesta = Console.ReadLine();

                if (respuesta.ToLower() != "s")
                {
                    jugarDeNuevo = false;
                }

                Console.Clear();
            }

            Console.WriteLine("¡Gracias por jugar!");
        }
    }
}


