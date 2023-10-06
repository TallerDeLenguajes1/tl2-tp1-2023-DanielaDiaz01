﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EmpresaCadeteria;

internal class Program
{
    static void Main()
    {
        //Cargo datos de archivos CSV para Cadeteria, Cadetes, y Clientes
        List<Cadeteria> cadeterias = CargarCadeteriasDesdeCSV();
        List<Cadete> cadetes = CargarCadetesDesdeCSV();

        //Creo una instancia de Cadeteria
        Cadeteria miCadeteria = cadeterias[0];

        //ejemplos para ver si funciona correctamente
        //Accedo al nombre de la primera cadetería
        string nombreCadeteria = miCadeteria.Nombre;
        Console.WriteLine($"> Nombre: {miCadeteria.Nombre}");

        //Acceder al telefono de la primera cadetería
        string numeroPedidos = miCadeteria.Telefono;
        Console.WriteLine($"> Telefono: {miCadeteria.Telefono}");

      
        // Mostrar menú y gestionar pedidos
        bool salir = false;
        while (!salir)
        {
            Console.WriteLine("Sistema de Cadetería");
            Console.WriteLine("1. Dar de alta pedidos");
            Console.WriteLine("2. Asignar pedidos a cadetes");
            Console.WriteLine("3. Cambiar estado de pedidos");
            Console.WriteLine("4. Reasignar pedidos a otro cadete");
            Console.WriteLine("5. Mostrar informe de pedidos");
            Console.WriteLine("6. Salir");
            Console.Write("Seleccione una opción: ");

            if (int.TryParse(Console.ReadLine(), out int opcion))
            {
                switch (opcion)
                {
                    case 1:
                    // Método para dar de alta un pedido
                    Console.WriteLine("Ingrese el número del cadete al que desea asignar el pedido (1,2,3):");
                    int idCadete = int.Parse(Console.ReadLine());

                    // Buscar el cadete por ID (debes implementar este método)
                    Cadete cadete = BuscarCadetePorId(idCadete);

                    if (cadete == null)
                    {
                        Console.WriteLine("Cadete no encontrado.");
                        break;
                    }

                    Console.WriteLine("Ingrese el número del pedido:");
                    int numeroPedido = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese las observaciones del pedido:");
                    string observacionPedido = Console.ReadLine();


                    // Llama al método DarDeAltaPedido del cadete para dar de alta el pedido
                    cadete.DarDeAltaPedido(numeroPedido, observacionPedido, EstadoPedido.Pendiente, cliente);

                    Console.WriteLine("Pedido dado de alta correctamente.");
                    break;

                    case 2:
                        // Implementar asignar pedidos a cadetes
                        break;
                    case 3:
                        // Implementar cambiar estado de pedidos
                        break;
                    case 4:
                        // Implementar reasignar pedidos a otro cadete
                        break;
                    case 5:
                        // Implementar mostrar informe de pedidos
                        break;
                    case 6:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Opción no válida. Intente nuevamente.");
            }
        }
    }

    // Métodos para cargar datos desde archivos CSV (implementar)
    static List<Cadeteria> CargarCadeteriasDesdeCSV(){
        List<Cadeteria> cadeterias = new List<Cadeteria>();
        try{
            var lineas = File.ReadAllLines("cadeteria.csv");
            foreach (var linea in lineas.Skip(1)) // Saltar la primera linea (encabezado)
            {
                var campos = linea.Split(',');
                if (campos.Length >= 2)
                {
                    string nombre = campos[0];
                    string telefono = campos[1];
                    cadeterias.Add(new Cadeteria(nombre, telefono));
                }
            }
        }
        catch (Exception ex){
            Console.WriteLine($"Error al cargar cadeterías desde CSV: {ex.Message}");
        }
        return cadeterias;
    }

    static List<Cadete> CargarCadetesDesdeCSV(){
       List<Cadete> cadetes = new List<Cadete>();
        try{
            var lineas = File.ReadAllLines("cadete.csv");
            foreach (var linea in lineas.Skip(1)) // Saltar la primera linea (encabezado)
            {
                var campos = linea.Split(',');
                if (campos.Length >= 4)
                {
                    int id = int.Parse(campos[0]);
                    string nombre = campos[1];
                    string direccion = campos[2];
                    string telefono = campos[3];
                    cadetes.Add(new Cadete(id, nombre, direccion, telefono));
                }
            }
        }
        catch (Exception ex){
            Console.WriteLine($"Error al cargar cadetes desde CSV: {ex.Message}");
        }
        return cadetes;
    }

}