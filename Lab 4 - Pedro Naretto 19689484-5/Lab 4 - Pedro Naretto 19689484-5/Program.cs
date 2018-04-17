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
                    Cliente cliente = Dios.CrearCliente();

                    Interaccion interaccion1 = new Interaccion(cliente, Sucursal1);

                    cliente.Compra = interaccion1.ArrendaAutos();
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
