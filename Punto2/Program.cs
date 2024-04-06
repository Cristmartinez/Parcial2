namespace Punto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool volver = true;

            while (volver)
            {
                const double BONO = 0.4;
                const decimal MULTA = 20000;
                const decimal INTERES_MENSUAL = 0.025m; // Tasa mensual para calcular intereses sobre préstamos

                string continuar;

                // Variables para el primer socio
                decimal aporteMensualSocio1, rendimientoMensualSocio1 = 0, aporteTotalSocio1 = 0, rendimientoTotalSocio1 = 0, bonoMensualSocio1 = 0, bonoTotalSocio1 = 0, aporteTotalNetoSocio1, tasaMensualSocio1;
                decimal prestamoSolicitadoSocio1 = 0;
                int mesPrestamoSocio1 = -1; // Inicializamos en -1 para indicar que no se ha solicitado préstamo

                // Variables para el segundo socio
                decimal aporteMensualSocio2, rendimientoMensualSocio2 = 0, aporteTotalSocio2 = 0, rendimientoTotalSocio2 = 0, bonoMensualSocio2 = 0, bonoTotalSocio2 = 0, aporteTotalNetoSocio2, tasaMensualSocio2;
                decimal prestamoSolicitadoSocio2 = 0;
                int mesPrestamoSocio2 = -1;

                Random random = new Random();

                for (int mes = 1; mes <= 12; mes++)
                {
                    Console.WriteLine($"Mes {mes}:");

                    // Primer socio
                    Console.WriteLine("=== Socio 1 ===");
                    Console.Write("Ingrese la cantidad de dinero que desea ahorrar: ");
                    aporteMensualSocio1 = Convert.ToDecimal(Console.ReadLine());

                    if (aporteMensualSocio1 == 0)
                    {
                        Console.WriteLine("Socio 1: No ha realizado aportes. Se aplicará una multa de $20,000.");
                        aporteMensualSocio1 -= MULTA;
                    }

                    tasaMensualSocio1 = (decimal)random.Next(1, 51) / 10;
                    rendimientoMensualSocio1 = aporteMensualSocio1 * (tasaMensualSocio1 / 100);

                    if (tasaMensualSocio1 < 1.5M)
                    {
                        bonoMensualSocio1 = aporteMensualSocio1 * (decimal)BONO;
                        bonoTotalSocio1 += bonoMensualSocio1;
                    }
                    
                    aporteTotalSocio1 += aporteMensualSocio1;
                    rendimientoTotalSocio1 += rendimientoMensualSocio1;

                    Console.WriteLine($"Aportes: {aporteMensualSocio1}");
                    Console.WriteLine($"Rendimientos: {rendimientoMensualSocio1}");
                    Console.WriteLine($"Bono: {bonoMensualSocio1}");

                    // Solicitar préstamo (si corresponde)
                    if (mesPrestamoSocio1 == -1)
                    {
                        Console.Write("¿Desea solicitar un préstamo? (s/n): ");
                        string respuesta = Console.ReadLine().ToLower();
                        if (respuesta == "s")
                        {
                            Console.Write("Ingrese el valor del préstamo: ");
                            prestamoSolicitadoSocio1 = Convert.ToDecimal(Console.ReadLine());
                            if (prestamoSolicitadoSocio1 <= aporteTotalSocio1)
                            {
                                mesPrestamoSocio1 = mes;
                                Console.WriteLine($"Préstamo de ${prestamoSolicitadoSocio1} aprobado.");
                            }
                            else
                            {
                                Console.WriteLine("El valor del préstamo excede el monto total ahorrado. No se aprobó el préstamo.");
                            }
                        }
                    }

                    // Segundo socio
                    Console.WriteLine("\n=== Socio 2 ===");
                    Console.Write("Ingrese la cantidad de dinero que desea ahorrar: ");
                    aporteMensualSocio2 = Convert.ToDecimal(Console.ReadLine());

                    if (aporteMensualSocio2 == 0)
                    {
                        Console.WriteLine("Socio 2: No ha realizado aportes. Se aplicará una multa de $20,000.");
                        aporteMensualSocio2 -= MULTA;
                    }

                    tasaMensualSocio2 = (decimal)random.Next(1, 51) / 10;
                    rendimientoMensualSocio2 = aporteMensualSocio2 * (tasaMensualSocio2 / 100);

                    if (tasaMensualSocio2 < 1.5M)
                    {
                        bonoMensualSocio2 = aporteMensualSocio2 * (decimal)BONO;
                        bonoTotalSocio2 += bonoMensualSocio2;
                    }

                    aporteTotalSocio2 += aporteMensualSocio2;
                    rendimientoTotalSocio2 += rendimientoMensualSocio2;

                    Console.WriteLine($"Aportes: {aporteMensualSocio2}");
                    Console.WriteLine($"Rendimientos: {rendimientoMensualSocio2}");
                    Console.WriteLine($"Bono: {bonoMensualSocio2}");

                    // Solicitar préstamo (si corresponde)
                    if (mesPrestamoSocio2 == -1)
                    {
                        Console.Write("¿Desea solicitar un préstamo? (s/n): ");
                        string respuesta = Console.ReadLine().ToLower();
                        if (respuesta == "s")
                        {
                            Console.Write("Ingrese el valor del préstamo: ");
                            prestamoSolicitadoSocio2 = Convert.ToDecimal(Console.ReadLine());
                            if (prestamoSolicitadoSocio2 <= aporteTotalSocio2)
                            {
                                mesPrestamoSocio2 = mes;
                                Console.WriteLine($"Préstamo de ${prestamoSolicitadoSocio2} aprobado.");
                            }
                            else
                            {
                                Console.WriteLine("El valor del préstamo excede el monto total ahorrado. No se aprobó el préstamo.");
                            }
                        }
                    }
                }

                // Calcular intereses para el primer socio
                decimal interesesSocio1 = 0;
                if (mesPrestamoSocio1 != -1)
                {
                    for (int mes = mesPrestamoSocio1 + 1; mes <= 12; mes++)
                    {
                        interesesSocio1 += prestamoSolicitadoSocio1 * INTERES_MENSUAL;
                    }
                }

                // Calcular intereses para el segundo socio
                decimal interesesSocio2 = 0;
                if (mesPrestamoSocio2 != -1)
                {
                    for (int mes = mesPrestamoSocio2 + 1; mes <= 12; mes++)
                    {
                        interesesSocio2 += prestamoSolicitadoSocio2 * INTERES_MENSUAL;
                    }
                }

                // Liquidación de la natillera a final de año
                decimal totalNetoSocio1 = aporteTotalSocio1 + rendimientoTotalSocio1 + bonoTotalSocio1 - prestamoSolicitadoSocio1 - interesesSocio1;
                decimal totalNetoSocio2 = aporteTotalSocio2 + rendimientoTotalSocio2 + bonoTotalSocio2 - prestamoSolicitadoSocio2 - interesesSocio2;

                Console.WriteLine("\n=== Liquidación de la Natillera ===");
                Console.WriteLine($"Socio 1: Aportes totales: {aporteTotalSocio1}, Rendimientos totales: {rendimientoTotalSocio1}, Bonos totales: {bonoTotalSocio1}, Préstamo solicitado: {prestamoSolicitadoSocio1}, Intereses generados: {interesesSocio1}, Total neto: {totalNetoSocio1}");
                Console.WriteLine($"Socio 2: Aportes totales: {aporteTotalSocio2}, Rendimientos totales: {rendimientoTotalSocio2}, Bonos totales: {bonoTotalSocio2}, Préstamo solicitado: {prestamoSolicitadoSocio2}, Intereses generados: {interesesSocio2}, Total neto: {totalNetoSocio2}");

                // Preguntar si se desea continuar
                Console.WriteLine("\n¿Desea Ingresar a la natillera para el siguiente año? (s/n)");
                continuar = Console.ReadLine().ToLower();
                if (continuar == "n") volver = false;
            }
        }
    }
}
            

    

