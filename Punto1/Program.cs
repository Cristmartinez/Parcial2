namespace Punto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Juego adivina El numero 
            //Muestra el mensaje de entrada
            Console.WriteLine("Bienvenidos al juego Adivina el numero o quedaras atrapado");

            // Creacion de Bucle para los jugadores 

            while (true);
            {
                //Declaramos las variables 
                //int numJugadores, rangoMin = 0, rangoMax = 0, random, adivinanza;

                Console.WriteLine("Bienvenidos al juego Adivina el numero o quedaras atrapado");
                int numJugadores = int.Parse(Console.ReadLine());
                int rangoMin = 0;
                int rangoMax = 0; 

                // numero de jugadores 2 a 4 

                Console.WriteLine("Ingrese el numero de Jugadores (Entre 2 y 4 Jugadores): "); 
                numJugadores = Convert.ToInt32(Console.ReadLine());

                switch (numJugadores)
                {
                    case 2:
                        rangoMax = 50;
                        break;
                    case 3:
                        rangoMax = 100;
                        break;
                    case 4:
                        rangoMax = 200;
                        break;
                    default:
                        Console.WriteLine("No es posible agregar mas Jugadores");
                    
                }
                //numero aleatorio
                int random = new Random().Next(rangoMin, rangoMax + 1);
                Console.WriteLine("Numero Aleatorio se generara entre " + rangoMin + "y" + rangoMax + ". ¡Que comience el juego!");
                

                bool Ganador = false;
                int jugadorActual = 1;


                while (!Ganador)
                {
                    Console.WriteLine("Jugador" + jugadorActual + "," + "ingrese su numero: ");
                    int adivinanza = Convert.ToInt32(Console.ReadLine());

                    if (adivinanza < random)
                    {
                        Console.WriteLine("MAYOR");
                    }
                    else if (adivinanza > random)
                    {
                        Console.WriteLine("MENOR");
                    }
                    else
                    {
                        Console.WriteLine("¡Felicitaciones HAS GANADO!");
                    }

                }

                }
                  

        }
    }
}
