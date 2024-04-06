namespace Punto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool volver = true;

            while (volver)
            {
                const double BONO = 0.4; // Porcentaje del bono
                string continuar;

                // Variables para el primer socio
                decimal aporteMensualSocio1, rendimientoMensualSocio1 = 0, aporteTotalSocio1 = 0, rendimientoTotalSocio1 = 0, bonoMensualSocio1 = 0, bonoTotalSocio1 = 0, aporteTotalNetoSocio1, tasaMensualSocio1;

                // Variables para el segundo socio
                decimal aporteMensualSocio2, rendimientoMensualSocio2 = 0, aporteTotalSocio2 = 0, rendimientoTotalSocio2 = 0, bonoMensualSocio2 = 0, bonoTotalSocio2 = 0, aporteTotalNetoSocio2, tasaMensualSocio2;

                Random random = new Random();

                for (int mes = 1; mes <= 12; mes++)
                {
                    Console.WriteLine($"Mes {mes}:");

                    // Primer socio
                    Console.WriteLine("=== Socio 1 ===");
                    Console.Write("Ingrese la cantidad de dinero que desea ahorrar: ");
                    aporteMensualSocio1 = Convert.ToDecimal(Console.ReadLine());

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

                    // Segundo socio
                    Console.WriteLine("\n=== Socio 2 ===");
                    Console.Write("Ingrese la cantidad de dinero que desea ahorrar: ");
                    aporteMensualSocio2 = Convert.ToDecimal(Console.ReadLine());

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
                }

                // Cálculo del total neto para el primer socio
                aporteTotalNetoSocio1 = rendimientoTotalSocio1 + aporteTotalSocio1 + bonoTotalSocio1;

                // Cálculo del total neto para el segundo socio
                aporteTotalNetoSocio2 = rendimientoTotalSocio2 + aporteTotalSocio2 + bonoTotalSocio2;

                Console.WriteLine("\n=== Liquidación de la Natillera ===");
                Console.WriteLine($"Socio 1 - Aportes totales: {aporteTotalSocio1}, Rendimientos totales: {rendimientoTotalSocio1}, Bonos totales: {bonoTotalSocio1}, Total neto: {aporteTotalNetoSocio1}");
                Console.WriteLine($"Socio 2 - Aportes totales: {aporteTotalSocio2}, Rendimientos totales: {rendimientoTotalSocio2}, Bonos totales: {bonoTotalSocio2}, Total neto: {aporteTotalNetoSocio2}");

                Console.WriteLine("\n¿Desea Ingresar a la natillera para el siguiente año? (s/n)");
                continuar = Console.ReadLine().ToLower();
                if (continuar == "n") volver = false;
            }
        }
    }
}
    

