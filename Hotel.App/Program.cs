using System;
using System.Collections.Generic;
using Hotel.Modelos;

namespace Hotel.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotel.Modelos.Hotel hotel = new Hotel.Modelos.Hotel();
            int opcion = 0;

            while (opcion != 5)
            {
                Console.WriteLine("\n===== SISTEMA DE RESERVAS - HOTEL =====");
                Console.WriteLine("1. Registrar nueva reserva");
                Console.WriteLine("2. Listar todas las reservas");
                Console.WriteLine("3. Calcular ingreso total");
                Console.WriteLine("4. Mostrar reserva de mayor duracion");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opcion: ");

                string entrada = Console.ReadLine();

                switch (entrada)
                {
                    case "1":
                        Console.Write("Nombre del cliente: ");
                        string cliente = Console.ReadLine();

                        Console.Write("Numero de habitacion: ");
                        int habitacion = int.Parse(Console.ReadLine());

                        Console.Write("Fecha de ingreso (dd/mm/aaaa): ");
                        string fecha = Console.ReadLine();

                        Console.Write("Numero de noches: ");
                        int noches = int.Parse(Console.ReadLine());

                        Console.Write("Precio por noche: ");
                        double precio = double.Parse(Console.ReadLine());

                        Reserva nueva = new Reserva(cliente, habitacion, fecha, noches, precio);
                        hotel.AgregarReserva(nueva);
                        Console.WriteLine("Reserva registrada correctamente.");
                        break;

                    case "2":
                        List<Reserva> todas = hotel.ObtenerTodas();
                        if (todas.Count == 0)
                        {
                            Console.WriteLine("No hay reservas registradas.");
                        }
                        else
                        {
                            Console.WriteLine("\n--- Lista de reservas ---");
                            foreach (Reserva r in todas)
                            {
                                Console.WriteLine(r.ToString());
                            }
                        }
                        break;

                    case "3":
                        double total = hotel.CalcularIngresoTotal();
                        Console.WriteLine("Ingreso total esperado: " + total);
                        break;

                    case "4":
                        Reserva mayor = hotel.ObtenerMayorDuracion();
                        if (mayor == null)
                        {
                            Console.WriteLine("No hay reservas registradas.");
                        }
                        else
                        {
                            Console.WriteLine("Reserva de mayor duracion:");
                            Console.WriteLine(mayor.ToString());
                        }
                        break;

                    case "5":
                        opcion = 5;
                        Console.WriteLine("Saliendo...");
                        break;

                    default:
                        Console.WriteLine("Opcion no valida.");
                        break;
                }
            }
        }
    }
}