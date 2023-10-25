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
        static int MAPBrooks = 0;
        static int mWatches = 0;
        static int totalPhones = 0;
        static int totalPads = 0;
        static int totalMAPBrooks = 0;
        static int totalWatches = 0;

        static void PantallaInicio()
        {

            while (true)
            {

                Console.WriteLine("================================"+
                "Productos de mPhone"+
                "================================"+
                "1: Ventas de mPhone 3000"+
                "2: Ventas de mPad 3500"+
                "3: Ventas de MAPBrook 3800"+
                "4: Ventas de mWatch 8000"+
                "5: Salir"+
                "================================"+
                "Ingrese una opción:");

                int opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcion)
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

        static void RegistrarVenta(string producto)
        {
            while (true)
            {
                Console.WriteLine("================================"+
                $"Registrar Venta de {producto}"+
                "================================"+
                "1: Registrar Venta"+
                "2: Registrar Devolución"+
                "3: Menu Principal"+
                "================================"+
                "Ingrese una opción:");
                int opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        RegistrarDevolucion(producto);
                        break;
                    case 2:
                        RegresarProducto(producto);
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("ERROR");
                        break;
                }
            }
        }

        static void RegistrarDevolucion(string producto)
        {
            Console.WriteLine("================================"+
            $"Registrar venta de {producto}"+
            "================================"+
            $"Se va a registrar la venta de un{producto}"+
            "¿Desea Continuar?"+
            "1: Sí"+
            "2: No"+
            "================================"+
            "Ingrese una opción:");
            int opcion = int.Parse(Console.ReadLine());
            Console.Clear();
            if (opcion == 1)
            {
                switch (producto)
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

        static void RegresarProducto(string producto)
        {
            Console.WriteLine("================================"+
            $"Registrar devolución de:"+
            "================================"+
            $"Se va a registrar la devolución de un{producto}"+
            "¿Desea Continuar?"+
            "1: Sí"+
            "2: No"+
            "================================"+
            "Ingrese una opción:");
            int opcion = int.Parse(Console.ReadLine());
            Console.Clear();
            if (opcion == 1)
            {
                switch (producto)
                {
                    case "mPhone 3000":
                        if (mPhones > 0)
                        {
                            mPhones--;
                            totalPhones--;
                        }
                        else
                        {
                            Console.WriteLine("ERROR");
                        }
                        break;
                    case "mPad 3500":
                        if (mPads > 0)
                        {
                            mPads--;
                            totalPads--;
                        }
                        else
                        {
                            Console.WriteLine("ERROR");
                        }
                        break;
                    case "MAPBrook 3800":
                        if (MAPBrooks > 0)
                        {
                            MAPBrooks--;
                            totalMAPBrooks--;
                        }
                        else
                        {
                            Console.WriteLine("ERROR");
                        }
                        break;
                    case "mWatch 8000":
                        if (mWatches > 0)
                        {
                            mWatches--;
                            totalWatches--;
                        }
                        else
                        {
                            Console.WriteLine("ERROR");
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
