using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4___Pedro_Naretto_19689484_5
{
    class Interaccion
    {
        Cliente Cliente;
        Sucursal Sucursal;

        public Interaccion(Cliente cliente, Sucursal sucursal)
        {
            this.Cliente = cliente;
            this.Sucursal = sucursal;
        }

        public List<Vehiculos> ArrendaAutos()
        {
                List<Vehiculos> OpcionesParaCliente = new List<Vehiculos> { };

                    if (Cliente.TipoLicencia.Contains("Licencia para autos"))
                    {
                    foreach (Vehiculos v in Sucursal.ListaVehiculos)
                        if (v is Autos && v.Stock > 0)
                        {
                            OpcionesParaCliente.Add(v);
                        }
                    }
                    if (Cliente.TipoLicencia.Contains("Licencia para buses"))
                    {
                    foreach (Vehiculos v in Sucursal.ListaVehiculos)
                        if (v is Buses && v.Stock > 0)
                        {
                            OpcionesParaCliente.Add(v);
                        }

                    if (Cliente.TipoLicencia.Contains("Licencia para camiones"))
                    {
                    foreach (Vehiculos v in Sucursal.ListaVehiculos)
                        if (v is Camion && v.Stock > 0)
                        {
                            OpcionesParaCliente.Add(v);
                        }
                    }
                }
                if (Sucursal.ListaVehiculos.Count() == 0 & OpcionesParaCliente.Count() == 0)
                {
                    Console.WriteLine("No tenemos vehiculos para ofrecerle");
                    return OpcionesParaCliente;
                }
                else
                {
                    Console.Write("Estos vehiculos tenemos para ofrecerle dado sus licencias: ");
                    List<Vehiculos> ListaArriendoCliente = new List<Vehiculos> { };
                    while (true)
                    {
                        int x = 1;
                        Console.WriteLine("Escoja el numero del auto que decea comprar: ");
                        Console.WriteLine("0) Ninguno");
                        foreach (Vehiculos vehiculo in OpcionesParaCliente)
                        {
                            Console.WriteLine($"{x}){vehiculo.Marca}, {vehiculo.Modelo}");
                            x++;
                        }
                        int resultado;

                        int.TryParse(Console.ReadLine(), out resultado);

                        while (resultado < 0 & resultado >= OpcionesParaCliente.Count())
                        {
                            Console.WriteLine("Comando inválido");
                            Console.WriteLine("Escoja un vehiculo");
                            int.TryParse(Console.ReadLine(), out resultado);
                        }
                    if (resultado > 0 && resultado <= OpcionesParaCliente.Count())
                    {
                        int cantidad;
                        Console.Write($"Cuantos decea arrendar? Tiene un maximo de {OpcionesParaCliente[resultado - 1].Stock}: ");
                        int.TryParse(Console.ReadLine(), out cantidad);
                        while (cantidad > OpcionesParaCliente[resultado - 1].Stock)
                        {
                            Console.WriteLine("No hay tal cantidad de vahiculos disponibles");
                            Console.Write($"Cuantos decea arrendar? Tiene un maximo de {OpcionesParaCliente[resultado - 1].Stock}: ");
                            int.TryParse(Console.ReadLine(), out cantidad);
                        }
                        if (OpcionesParaCliente[resultado - 1] is Autos)
                        {
                            Autos V = new Autos(OpcionesParaCliente[resultado - 1].Marca, OpcionesParaCliente[resultado - 1].Modelo, OpcionesParaCliente[resultado - 1].Año, OpcionesParaCliente[resultado - 1].Precio, OpcionesParaCliente[resultado - 1].Patente, cantidad, new List<Accesorios> { });
                            ListaArriendoCliente.Add(V);
                        }
                        if (OpcionesParaCliente[resultado - 1] is Buses)
                        {
                           Buses V = new Buses(OpcionesParaCliente[resultado - 1].Marca, OpcionesParaCliente[resultado - 1].Modelo, OpcionesParaCliente[resultado - 1].Año, OpcionesParaCliente[resultado - 1].Precio, OpcionesParaCliente[resultado - 1].Patente, cantidad, new List<Accesorios> { });
                            ListaArriendoCliente.Add(V);
                        }
                        if (OpcionesParaCliente[resultado - 1] is Camion)
                        {
                            Camion V = new Camion(OpcionesParaCliente[resultado - 1].Marca, OpcionesParaCliente[resultado - 1].Modelo, OpcionesParaCliente[resultado - 1].Año, OpcionesParaCliente[resultado - 1].Precio, OpcionesParaCliente[resultado - 1].Patente, cantidad, new List<Accesorios> { });
                            ListaArriendoCliente.Add(V);
                        }

                        Sucursal.ListaVehiculos[Sucursal.ListaVehiculos.IndexOf(OpcionesParaCliente[resultado - 1])].Stock -= cantidad;


                        if (Sucursal.ListaVehiculos[Sucursal.ListaVehiculos.IndexOf(OpcionesParaCliente[resultado - 1])].Stock == 0)
                        { 
                            OpcionesParaCliente.Remove(OpcionesParaCliente[resultado - 1]);
                        }

                        Console.WriteLine("Decea Agregarles algun accesorio: \n1)Si \n2)No");
                        string respuesta = Console.ReadLine();
                        while (respuesta != "1" & respuesta != "2")
                        {
                            Console.WriteLine("Comando Invalido");
                            Console.WriteLine("Decea Agregarle algun accesorio: \n1)Si \n2)No");
                            respuesta = Console.ReadLine();
                        }
                        if (respuesta == "1")
                        {
                            ListaArriendoCliente[ListaArriendoCliente.Count() - 1].AgregarAccesorio(Sucursal.AccesoriosSucursal);
                        }
                        int Dias;
                        Console.WriteLine("Cuantos dias los va arrendar?:");
                        int.TryParse(Console.ReadLine(), out Dias);
                        Sucursal.Gestion.Add(new Arriendo(DateTime.Now, DateTime.Today.AddDays(Dias), Sucursal, Cliente, ListaArriendoCliente));
                        }
                        else if (resultado == 0)
                        {
                            break;
                        }

                    }

                    foreach(Vehiculos vehiculo in Sucursal.ListaVehiculos)
                    {
                    Console.WriteLine($"{vehiculo.Marca}--{vehiculo.Modelo}--{vehiculo.Stock}");

                    }
                    foreach (Vehiculos vehiculo in ListaArriendoCliente)
                    {
                        Console.WriteLine($"{vehiculo.Marca}--{vehiculo.Modelo}--{vehiculo.Stock}");

                    }

                return ListaArriendoCliente;

                }
               
        }
    }
}
