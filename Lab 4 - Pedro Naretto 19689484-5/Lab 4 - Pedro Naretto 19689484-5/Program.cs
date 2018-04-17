using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4___Pedro_Naretto_19689484_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Municipalidad Municipalidad = new Municipalidad();

            Dios Dios = new Dios(Municipalidad);

            Sucursal Sucursal1 = Dios.CrearSucursal();

            while (true)
            {
                Console.WriteLine("Hay CLiente? \n1)Si \n2)No");
                string respuesta = Console.ReadLine();
                while(respuesta != "1" & respuesta != "2")
                {
                    Console.WriteLine("Comando invalido");
                    Console.WriteLine("Hay CLiente? \n1)Si \n2)No");
                    respuesta = Console.ReadLine();
                }
                if (respuesta == "1")
                {
                    Console.WriteLine($"Bien venido a {Sucursal1.Nombre}");
                    Console.WriteLine("Cual es su nombre");
                    Console.WriteLine("Le ofrecemos autos con:\n0)Nada \n1)DVD inluido? \n2)Maleteros grandes? \n3)Asientos extras \n4)Que sea electrico");
                    string nombre = Console.ReadLine();
                    Cliente cliente;
                    bool existe = true;
                        if (existe)
                        {
                            foreach( Arriendo arriendo in Sucursal1.Gestion)
                            {
                                if (nombre == arriendo.cliente.Nombre)
                                {
                                    cliente = arriendo.cliente;
                                    break;
                                }
                                existe = false;
                            }
                            if (existe)
                            {
                                break;
                            }
                            else
                            {
                                cliente = Dios.CrearCliente(nombre);
                            }
                        }

                    Console.WriteLine("Que decea hacer: \n1)Devolver vehiculo \n2)Arrendar vehiculo");
                    string accion = Console.ReadLine();
                    if (accion == "1")
                    {
                        Sucursal1.RecibirVehiculoRentado(cliente);
                    }
                    else if (accion == "2")
                    {
                        Interaccion interaccion1 = new Interaccion(cliente, Sucursal1);

                        cliente.Compra = interaccion1.ArrendaAutos();
                    }
                }
                else if (respuesta == "2")
                {
                    Console.WriteLine("Ya se termino el dia, adios");
                    break;
                }
            }

            Console.WriteLine("Ya se termino el programa");

            Console.ReadKey();
        }
    }
}
