using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4___Pedro_Naretto_19689484_5
{
    class Municipalidad
    {

        public void DarLicencia(Cliente cliente, string licencia)
        {
            Random rnd = new Random();
            if (licencia == "Licencia para camiones")
            {
                if ( cliente is Empresa)
                {
                    int x = rnd.Next(0, 100);
                    if (x <= 63)
                    {
                        Console.WriteLine("Se le ha otorgado la licencia para camiones");
                        cliente.TipoLicencia.Add("Licencia para camiones");
                    }
                    else
                    {
                        Console.WriteLine("No se dio el permiso para camiones");
                    }
                }
                else
                {
                    Console.WriteLine("No se dio el permiso para camiones");
                }
            }
            else if (licencia == "Licencia para buses")
            {
                if (cliente is Empresa)
                {
                    int x = rnd.Next(0, 100);
                    if (x <= 80)
                    {
                        Console.WriteLine("Se le ha otorgado la licencia para buses");
                        cliente.TipoLicencia.Add("Licencia para buses");
                    }
                    else
                    {
                        Console.WriteLine("No se dio el permiso para buses");
                    }
                }
                else if (cliente is Organizacion)
                {
                    int x = rnd.Next(0, 100);
                    if (x <= 35)
                    {
                        Console.WriteLine("Se le ha otorgado la licencia para buses");
                        cliente.TipoLicencia.Add("Licencia para buses");
                    }
                    else
                    {
                        Console.WriteLine("No se dio el permiso para buses");
                    }
                }
                else if (cliente is Institucion)
                {
                    int x = rnd.Next(0, 100);
                    if (x <= 58)
                    {
                        Console.WriteLine("Se le ha otorgado la licencia para buses");
                        cliente.TipoLicencia.Add("Licencia para buses");
                    }
                    else
                    {
                        Console.WriteLine("No se dio el permiso para buses");
                    }
                }
                else
                {
                    Console.WriteLine("No se dio el permiso para buses");
                }
            }
            else if (licencia == "Licencia para autos")
            {
                Console.WriteLine("Se le ha otorgado la licencia para autos");
                cliente.TipoLicencia.Add("Licencia para autos");
            }
            else
            {
                Console.WriteLine("No se dio el permiso");
            }
        }
    }
}
