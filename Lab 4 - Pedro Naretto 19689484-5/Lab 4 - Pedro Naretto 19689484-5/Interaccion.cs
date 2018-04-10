using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4___Pedro_Naretto_19689484_5
{
    class Interaccion
    {
        ICliente cliente;
        Sucursal sucursal;

        public Interaccion(ICliente cliente, Sucursal sucursal)
        {
            this.cliente = cliente;
            this.sucursal = sucursal;
        }

        public List<Vehiculos> CualVehiculo(List<Vehiculos> listaVehiculos, ICliente cliente)
        {
            Console.Write("Estos vehiculos tenemos para ofrecerle");
            List<Vehiculos> listaOpcionCliente = new List<Vehiculos> { };
            int i = 1;
            foreach (Vehiculos vehiculo in listaVehiculos)
            {
                if (vehiculo.TipoLicencia == ICliente.TipoLicencia())
                {
                    Console.Write($"{i}.-  {vehiculo.modelo}");
                    listaOpcionCliente.Add(vehiculo);
                    i += 1;
                }
            }
            List<Vehiculos> listaCliente = new List<Vehiculos> { };
            int x = 0;
            while (true)
            {
                Console.WriteLine("Escoja el numero de auto que decea (si no decea ninguno oprima 0): ");
                string indice = Console.ReadLine();
                if (indice == "0")
                {
                    break;
                }
                else
                {
                    listaCliente.Add(listaOpcionCliente[x]);
                    x += 1;
                }
            }
            return listaCliente;
        }
    }
}
