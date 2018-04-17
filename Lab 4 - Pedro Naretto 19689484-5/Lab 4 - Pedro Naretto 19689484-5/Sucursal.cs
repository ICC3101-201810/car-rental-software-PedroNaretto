using System;
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
            List<Accesorios> acce = new List<Accesorios> { };
            Console.WriteLine("Tiene DVD incluido? \n1)Si \n2)No");
            string respuesta = Console.ReadLine();
            if (respuesta == "1")
            {
                acce.Add(new DVD());
            }
            Console.WriteLine("Tiene Corrida de asientos extra? \n1)Si \n2)No");
            respuesta = Console.ReadLine();
            if (respuesta == "1")
            {
                acce.Add(new AsientosExtras());
            }
            Console.WriteLine("Tiene Maletero grande? \n1)Si \n2)No");
            respuesta = Console.ReadLine();
            if (respuesta == "1")
            {
                acce.Add(new MaleteroGrande());
            }
            Console.WriteLine("Es electrico? \n1)Si \n2)No");
            respuesta = Console.ReadLine();
            if (respuesta == "1")
            {
                acce.Add(new Electrico());
            }
            ListaVehiculos.Add(new Autos(Marca, Modelo, Año, Precio, Patente, Stock, acce));

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
        public List<Vehiculos> AgregarMoto(List<Vehiculos> ListaVehiculos)
        {
            int Precio;
            int Stock;
            int Año;
            Console.WriteLine("Ingrese los datos del la moto que decea ingresar: ");
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
            ListaVehiculos.Add(new Motos(Marca, Modelo, Año, Precio, Patente, Stock, new List<Accesorios> { }));

            return ListaVehiculos;
        }
        public List<Vehiculos> AgregarAcuatico(List<Vehiculos> ListaVehiculos)
        {
            int Precio;
            int Stock;
            int Año;
            Console.WriteLine("Ingrese los datos del vehiculo acuatico que decea ingresar: ");
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
            ListaVehiculos.Add(new Acuaticos(Marca, Modelo, Año, Precio, Patente, Stock, new List<Accesorios> { }));

            return ListaVehiculos;
        }
        public List<Vehiculos> AgregarMaquinariaPesada(List<Vehiculos> ListaVehiculos)
        {
            int Precio;
            int Stock;
            int Año;
            Console.WriteLine("Ingrese los datos de la maquinaria pesada que decea ingresar: ");
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
            ListaVehiculos.Add(new MaquinariaPesada(Marca, Modelo, Año, Precio, Patente, Stock, new List<Accesorios> { }));

            return ListaVehiculos;
        }
        public void RecibirVehiculoRentado( Cliente cliente)
        {
            Console.WriteLine("Entro al metodo");
            foreach (Arriendo arriendo in Gestion)
            {
                if (cliente == arriendo.cliente)
                {
                        Console.WriteLine("seguimos en el metodo");
                        int respuesta;
                        Console.WriteLine("Que vehiculo desea devolcer: ");
                        int x = 1;
                        foreach (Vehiculos vehiculo in arriendo.vehiculos)
                        {
                            Console.WriteLine($"{x}){vehiculo.Marca}, {vehiculo.Modelo}");
                        }
                        int.TryParse(Console.ReadLine(), out respuesta);
                        while (respuesta < 1 & respuesta > arriendo.vehiculos.Count())
                        {
                            Console.Beep();
                            Console.WriteLine("Comando invalido");
                            Console.WriteLine("Que vehiculo desea devolcer: ");
                            int c = 1;
                            foreach (Vehiculos vehiculo in arriendo.vehiculos)
                            {
                                Console.WriteLine($"{c}){vehiculo.Marca}, {vehiculo.Modelo}");
                            }
                            int.TryParse(Console.ReadLine(), out respuesta);
                        }

                        ListaVehiculos[ListaVehiculos.IndexOf(arriendo.vehiculos[respuesta - 1])].Stock += arriendo.vehiculos[respuesta - 1].Stock;
                        Gestion.Remove(arriendo);
                        Console.WriteLine("Gracias por devolve nustro vehiculo y gracias por preferirnos");

                    
                }
            }
        }
    }
}
