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
                int numJugadores, numMin = 0, numMax = 0, rango;
                bool Ganador;

                // numero de jugadores 

                Console.WriteLine("Ingrese el numero de Jugadores (Entre 2 y 4 Jugadores): "); 
                numJugadores = Convert.ToInt32(Console.ReadLine());

                switch (numJugadores)
                {
                    case 2:
                        numMax = 50;
                        break;
                    case 3:
                        numMax = 100;
                        break;
                    case 4:
                        numMax = 200;
                        break;
                    default:
                        Console.WriteLine("No es posible agregar mas Jugadores");
                    
                }
                rango = new Random().Next(numMin, numMax + 1);
                Console.WriteLine("Numero Aleatorio se generara entre " + numMin + "y" + numMax + ". ¡Que comience el juego!");


            }   

        }
    }
}
