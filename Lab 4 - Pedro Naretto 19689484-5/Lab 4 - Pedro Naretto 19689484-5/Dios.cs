using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4___Pedro_Naretto_19689484_5
{
    class Dios
    {
        Municipalidad Municipalidad;

        public Dios(Municipalidad municipalidad)
        {
            Municipalidad = municipalidad;
        }

        public Sucursal CrearSucursal()
        {
            Console.WriteLine("Nombre Sucursal: ");
            string Nombre = Console.ReadLine();
            Console.WriteLine("Ubicacion: ");
            string Ubicacion = Console.ReadLine();
            Sucursal Sucursal = new Sucursal(Nombre, new List<Vehiculos> { }, Ubicacion, new List<Accesorios> { }, new List<Arriendo> { });
            while (true)
            {
                int resultado;
                Console.WriteLine($"Decea agregar algun vehiculo a su sucursal {Sucursal.Nombre}? \n 0)Nada \n 1)Auto \n 2)Bus \n 3)Camion \n 4)Moto \n 5)Acuatico  \n 6)Maquinaria Pesada");
                string resultadoS = Console.ReadLine();
                while (resultadoS != "1" & resultadoS != "2" & resultadoS != "3" & resultadoS != "4" & resultadoS != "5" & resultadoS != "6" & resultadoS != "0")
                {
                    Console.WriteLine("Comando inválido");
                    Console.WriteLine($"Decea agregar algun vehiculo a su sucursal {Sucursal.Nombre} \n 0)Nada \n 1)Auto \n 2)Bus \n 3)Camion");
                    resultadoS = Console.ReadLine();

                }

                int.TryParse(resultadoS, out resultado);

                if (resultado == 1)
                {
                    Sucursal.AgregarAuto(Sucursal.ListaVehiculos);

                    continue;
                }
                else if (resultado == 2)
                {
                    Sucursal.AgregarBus(Sucursal.ListaVehiculos);
                    continue;
                }
                else if (resultado == 3)
                {
                    Sucursal.AgregarCamion(Sucursal.ListaVehiculos);
                    continue;
                }
                else if (resultado == 4)
                {
                    Sucursal.AgregarMoto(Sucursal.ListaVehiculos);
                    continue;
                }
                else if (resultado == 5)
                {
                    Sucursal.AgregarAcuatico(Sucursal.ListaVehiculos);
                    continue;
                }
                else if (resultado == 6)
                {
                    Sucursal.AgregarMaquinariaPesada(Sucursal.ListaVehiculos);
                    continue;
                }
                else if (resultado == 0)
                {
                    break;
                }
            }

            List<Accesorios> Accesorios = new List<Accesorios>{new Bluetooth(), new GPS(), new RuedaRepuesto(), new CortinaVentanas(), new SillaInfante() };

            while (true)
            {
                int Respuesta;
                Console.WriteLine("Que accesorios tendra su sucursal?: \n0)Nada");
                int x = 1;
                foreach (Accesorios accesorio in Accesorios)
                {
                    Console.WriteLine($"{x}){accesorio.Accesorio()}");
                    x++;
                }
                string respuestaS = Console.ReadLine();
                while (respuestaS != "1" & respuestaS != "2" & respuestaS != "3" & respuestaS != "4" & respuestaS != "5" & respuestaS != "0")
                {
                    x = 1;
                    Console.WriteLine("Comando invalido");
                    Console.WriteLine("Tenemos estos accesorios para ofrecerle:\n 0)Nada");
                    foreach (Accesorios accesorio in Accesorios)
                    {
                        Console.WriteLine($"{x}){accesorio.Accesorio()}");
                    }
                    respuestaS = Console.ReadLine();
                }
                int.TryParse(respuestaS, out Respuesta);
                if (Respuesta != 0)
                {
                    Sucursal.AccesoriosSucursal.Add(Accesorios[Respuesta - 1]);
                    Accesorios.Remove(Accesorios[Respuesta - 1]);
                }
                else if (Respuesta == 0)
                {
                    break;
                }
            }
            return Sucursal;
        }

        public Cliente CrearCliente(string Nombre)
        {
            Console.WriteLine("Llego cliente:");
            while (true)
            {
                Console.WriteLine("Que tipo de cliente es?(Escoja numero) \n 1)Persona \n 2)Empresa \n 3)Organizacion \n 4)Institucion ");
                string TipoCliente = Console.ReadLine();

                if (TipoCliente != "1" & TipoCliente != "2" & TipoCliente != "3" & TipoCliente != "4")
                {
                    Console.WriteLine("Tipo de cliente invalida");
                    Console.WriteLine("Que tipo de cliente es?(Escoja numero) \n 1)Persona \n 2)Empresa \n 3)Organizacion \n 4)Institucion ");
                    TipoCliente = Console.ReadLine();
                }

                if (TipoCliente == "1")
                {
                    Persona x =  new Persona(Nombre, new List<string> { }, new List<Vehiculos> { });
                    Municipalidad.DarLicencia(x, "Licencia para autos");
                    Municipalidad.DarLicencia(x, "Licencia para buses");
                    Municipalidad.DarLicencia(x, "Licencia para camiones");
                    Municipalidad.DarLicencia(x, "Licencia para motos");
                    Municipalidad.DarLicencia(x, "Licencia para acuaticos");
                    Municipalidad.DarLicencia(x, "Licencia para maquinaria pesada");

                    return x;
                }
                else if (TipoCliente == "2")
                {
                    Empresa x = new Empresa(Nombre, new List<string> { }, new List<Vehiculos> { });
                    Municipalidad.DarLicencia(x, "Licencia para autos");
                    Municipalidad.DarLicencia(x, "Licencia para buses");
                    Municipalidad.DarLicencia(x, "Licencia para camiones");
                    Municipalidad.DarLicencia(x, "Licencia para motos");
                    Municipalidad.DarLicencia(x, "Licencia para acuaticos");
                    Municipalidad.DarLicencia(x, "Licencia para maquinaria pesada");
                    return x;
                }
                else if (TipoCliente == "3")
                {
                    Organizacion x = new Organizacion(Nombre, new List<string> { }, new List<Vehiculos> { });
                    Municipalidad.DarLicencia(x, "Licencia para autos");
                    Municipalidad.DarLicencia(x, "Licencia para buses");
                    Municipalidad.DarLicencia(x, "Licencia para camiones");
                    Municipalidad.DarLicencia(x, "Licencia para motos");
                    Municipalidad.DarLicencia(x, "Licencia para acuaticos");
                    Municipalidad.DarLicencia(x, "Licencia para maquinaria pesada");
                    return x;
                }
                else if (TipoCliente == "4")
                {
                    Institucion x = new Institucion(Nombre, new List<string> { }, new List<Vehiculos> { });
                    Municipalidad.DarLicencia(x, "Licencia para autos");
                    Municipalidad.DarLicencia(x, "Licencia para buses");
                    Municipalidad.DarLicencia(x, "Licencia para camiones");
                    Municipalidad.DarLicencia(x, "Licencia para motos");
                    Municipalidad.DarLicencia(x, "Licencia para acuaticos");
                    Municipalidad.DarLicencia(x, "Licencia para maquinaria pesada");
                    return x;
                }
            }
        }
    }
}
