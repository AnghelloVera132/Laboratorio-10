using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_10
{
    internal class Program
    {
        static int mPhones = 0;
        static int mPads = 0;
        static int MAPBrooks= 0;
        static int mWatches = 0;

        static int totalPhones = 0;
        static int totalPads = 0;
        static int totalMAPBrooks = 0;
        static int totalWatches = 0;

        static void PantallaInicio()
        {
            
            while (true)
            {
                
                Console.WriteLine("================================");
                Console.WriteLine("Productos de mPhone");
                Console.WriteLine("================================");
                Console.WriteLine("1: Ventas de mPhone 3000");
                Console.WriteLine("2: Ventas de mPad 3500");
                Console.WriteLine("3: Ventas de MAPBrook 3800");
                Console.WriteLine("4: Ventas de mWatch 8000");
                Console.WriteLine("5: Salir");
                Console.WriteLine("================================");
                Console.WriteLine("Ingrese una opción:");

                int option = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (option)
                {
                    case 1:
                        RegistrarVenta("mPhone 3000");
                        break;
                    case 2:
                        RegistrarVenta("mPad 3500");
                        break;
                    case 3:
                        RegistrarVenta("MAPBrook 3800");
                        break;
                    case 4:
                        RegistrarVenta("mWatch 8000");
                        break;
                    case 5:
                        DisplaySalesAndReturns();
                        break;
                }
            }
        }

        static void RegistrarVenta(string productName)
        {
            while (true)
            {
                Console.WriteLine("================================");
                Console.WriteLine($"Registrar Venta de {productName}");
                Console.WriteLine("================================");
                Console.WriteLine("1: Registrar Venta");
                Console.WriteLine("2: Registrar Devolución");
                Console.WriteLine("3: Menu Principal");
                Console.WriteLine("================================");
                Console.WriteLine("Ingrese una opción:");
                int option = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (option)
                {
                    case 1:
                        RegistrarDevolucion(productName);
                        break;
                    case 2:
                        RegresarProducto(productName);
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, ingrese una opción válida.");
                        break;
                }
            }
        }

        static void RegistrarDevolucion(string productName)
        {
            Console.WriteLine("================================");
            Console.WriteLine($"Registrar venta de {productName}");
            Console.WriteLine("================================");
            Console.WriteLine($"Se va a registrar la venta de un{productName}");
            Console.WriteLine("¿Desea Continuar?");
            Console.WriteLine("1: Sí");
            Console.WriteLine("2: No");
            Console.WriteLine("================================");
            Console.WriteLine("Ingrese una opción:");
            int option = int.Parse(Console.ReadLine());
            Console.Clear();
            if (option == 1)
            {
                switch (productName)
                {
                    case "mPhone 3000":
                        mPhones++;
                        totalPhones++;
                        break;
                    case "mPad 3500":
                        mPads++;
                        totalPads++;
                        break;
                    case "MAPBrook 3800":
                        MAPBrooks++;
                        totalMAPBrooks++;
                        break;
                    case "mWatch 8000":
                        mWatches++;
                        totalWatches++;
                        break;
                }
            }
        }

        static void RegresarProducto(string productName)
        {
            Console.WriteLine("================================");
            Console.WriteLine($"Registrar devolución de:");
            Console.WriteLine("================================");
            Console.WriteLine($"Se va a registrar la devolución de un{productName}");
            Console.WriteLine("¿Desea Continuar?");
            Console.WriteLine("1: Sí");
            Console.WriteLine("2: No");
            Console.WriteLine("================================");
            Console.WriteLine("Ingrese una opción:");
            int option = int.Parse(Console.ReadLine());
            Console.Clear();
            if (option == 1)
            {
                switch (productName)
                {
                    case "mPhone 3000":
                        if (mPhones > 0)
                        {
                            mPhones--;
                            totalPhones--;
                            Console.WriteLine("Devolución registrada con éxito.");
                        }
                        else
                        {
                            Console.WriteLine("No hay suficientes productos para devolver.");
                        }
                        break;
                    case "mPad 3500":
                        if (mPads > 0)
                        {
                            mPads--;
                            totalPads--;
                            Console.WriteLine("Devolución registrada con éxito.");
                        }
                        else
                        {
                            Console.WriteLine("No hay suficientes productos para devolver.");
                        }
                        break;
                    case "MAPBrook 3800":
                        if (MAPBrooks > 0)
                        {
                            MAPBrooks--;
                            totalMAPBrooks--;
                            Console.WriteLine("Devolución registrada con éxito.");
                        }
                        else
                        {
                            Console.WriteLine("No hay suficientes productos para devolver.");
                        }
                        break;
                    case "mWatch 8000":
                        if (mWatches > 0)
                        {
                            mWatches--;
                            totalWatches--;
                            Console.WriteLine("Devolución registrada con éxito.");
                        }
                        else
                        {
                            Console.WriteLine("No hay suficientes productos para devolver.");
                        }
                        break;
                }
            }
        }

        static void DisplaySalesAndReturns()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("Reporte Final");
            Console.WriteLine("=================================");
            Console.WriteLine("Productos vendidos | Cantidad");
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"mPhones           |  {totalPhones}");
            Console.WriteLine($"mPads             |  {totalPads}");
            Console.WriteLine($"MAPBrooks         |  {totalMAPBrooks}");
            Console.WriteLine($"mWatches          |  {totalWatches}");
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"Total             |  {totalPhones + totalPads + totalMAPBrooks + totalWatches}");
            Console.WriteLine("================================="); 
            Console.WriteLine("¡Hasta luego!\n\n\n\n");







            Console.WriteLine("Diseñado Por: [Anghello Sebastian Vera Ramirez]");
        }

    }

}
