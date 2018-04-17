﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4___Pedro_Naretto_19689484_5
{
    class Sucursal
    {
        public string Nombre;
        public List<Vehiculos> ListaVehiculos;
        public string Ubicacion;
        public List<Accesorios> AccesoriosSucursal;
        public List<Arriendo> Gestion;

        public Sucursal(string nombre, List<Vehiculos> listaVehiculos, string ubicacion, List<Accesorios> accesoriosSucursal, List<Arriendo> gestion)
        {
            Nombre = nombre;
            ListaVehiculos = listaVehiculos;
            Ubicacion = ubicacion;
            AccesoriosSucursal = accesoriosSucursal;
            Gestion = gestion;
        }

        public List<Vehiculos> AgregarAuto(List<Vehiculos> ListaVehiculos)
        {
            int Precio;
            int Stock;
            int Año;
            Console.WriteLine("Ingrese los datos del auto que decea ingresar: ");
            Console.WriteLine("Marca: ");
            string Marca = Console.ReadLine();
            Console.WriteLine("Modelo: ");
            string Modelo = Console.ReadLine();
            Console.WriteLine("Año: ");
            int.TryParse(Console.ReadLine(), out Año);
            Console.WriteLine("Precio: ");
            int.TryParse(Console.ReadLine(), out Precio);
            Console.WriteLine("Patente: ");
            string Patente = Console.ReadLine();
            Console.WriteLine("Stock: ");
            int.TryParse(Console.ReadLine(), out Stock);
            ListaVehiculos.Add(new Autos(Marca, Modelo, Año, Precio, Patente, Stock, new List<Accesorios> { }));

            return ListaVehiculos;
        }
        public List<Vehiculos> AgregarCamion(List<Vehiculos> ListaVehiculos)
        {
            int Precio;
            int Stock;
            int Año;
            Console.WriteLine("Ingrese los datos del camion que decea ingresar: ");
            Console.WriteLine("Marca: ");
            string Marca = Console.ReadLine();
            Console.WriteLine("Modelo: ");
            string Modelo = Console.ReadLine();
            Console.WriteLine("Año: ");
            int.TryParse(Console.ReadLine(), out Año);
            Console.WriteLine("Precio: ");
            int.TryParse(Console.ReadLine(), out Precio);
            Console.WriteLine("Patente: ");
            string Patente = Console.ReadLine();
            Console.WriteLine("Stock: ");
            int.TryParse(Console.ReadLine(), out Stock);
            ListaVehiculos.Add(new Camion(Marca, Modelo, Año, Precio, Patente, Stock, new List<Accesorios> { }));

            return ListaVehiculos;
        }
        public List<Vehiculos> AgregarBus (List<Vehiculos> ListaVehiculos)
        {
            int Precio;
            int Stock;
            int Año;
            Console.WriteLine("Ingrese los datos del bus que decea ingresar: ");
            Console.WriteLine("Marca: ");
            string Marca = Console.ReadLine();
            Console.WriteLine("Modelo: ");
            string Modelo = Console.ReadLine();
            Console.WriteLine("Año: ");
            int.TryParse(Console.ReadLine(), out Año);
            Console.WriteLine("Precio: ");
            int.TryParse(Console.ReadLine(), out Precio);
            Console.WriteLine("Patente: ");
            string Patente = Console.ReadLine();
            Console.WriteLine("Stock: ");
            int.TryParse(Console.ReadLine(), out Stock);
            ListaVehiculos.Add(new Buses(Marca, Modelo, Año, Precio, Patente, Stock, new List<Accesorios> { }));

            return ListaVehiculos;
        }
    }
}
