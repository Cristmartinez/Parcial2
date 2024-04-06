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
                numJugadores = Convert.ToInt32(Console.ReadLine());
                //Declaro los valores del rango menor al rango menor permitido e inicilizo las variables en cero

                int valorMin = 0;
                int ValorMax = 0;

                //variable que me permite agregar varios casos en este caso participantes y asigno los rangos segun indicaciones
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
                //Generacion de numeros aleatorios 
                int numAleatorio = new Random().Next(valorMin, ValorMax + 1);

                Console.WriteLine($"Número aleatorio generado entre {valorMin} y {ValorMax}. ¡Comienza el juego!");

                bool ganadorJuego = false;
                int jugadorActual = 1;
                //para el blucle que me permite guardar a medida que se van agregando numeros pueda mostrar si es mayo o menor al numero ingresado
                while (!ganadorJuego)
                {
                    Console.Write($"Jugador {jugadorActual}, ingrese su número: ");
                    int numIngresado = Convert.ToInt32(Console.ReadLine());
                    //si el numero ingresado es mayor o menor muestra el mensaje
                    if (numIngresado < numAleatorio)
                    {
                        Console.WriteLine("MAYOR");
                    }
                    else if (numIngresado > numAleatorio)
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
                string jugarDeNuevo = Console.ReadLine().ToLower();

                if (jugarDeNuevo != "s")
                {
                    break;
                }

                Console.Clear();
            }

            Console.WriteLine("¡Gracias por jugar!");
        }
    }
}


