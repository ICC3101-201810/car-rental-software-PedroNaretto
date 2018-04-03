using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4___Pedro_Naretto_19689484_5
{
    class Interaccion
    {
        Cliente cliente;
        Sucursal sucursal;

        public Interaccion(Cliente cliente, Sucursal sucursal)
        {
            this.cliente = cliente;
            this.sucursal = sucursal;
        }

        public List<Vehiculos> CualVehiculo(List<Vehiculos> listaVehiculos, Cliente cliente)
        {
            Console.Write("Estos vehiculos tenemos para ofrecerle");
            List<Vehiculos> listaOpcionCliente = new List<Vehiculos> { };
            int i = 1;
            foreach (Vehiculos vehiculo in listaVehiculos)
            {
                if (vehiculo.TipoLicencia == Cliente.tipoLicencia())
                {
                    Console.Write($"{i}.-"vehiculo);
                    listaOpcionCliente.Add(vehiculo);
                    i += 1;
                }
            }
            List<Vehiculos> listaCliente = new List<Vehiculos> { };
            while (x)
            {
                Console.WriteLine("Escoja el numero de auto que decea (si no decea ninguno oprima 0): ");
                int indice = Console.ReadLine();
                if (indice == 0)
                {
                    break;
                }
                else
                {
                    listaCliente.Add(listaOpcionCliente[indice]);
                }
            }
        }
}
