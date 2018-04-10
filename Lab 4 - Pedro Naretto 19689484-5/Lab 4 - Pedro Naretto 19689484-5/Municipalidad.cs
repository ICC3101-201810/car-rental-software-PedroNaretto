using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4___Pedro_Naretto_19689484_5
{
    class Municipalidad
    {
        ICliente cliente;
        string licencia;

        public Municipalidad(ICliente cliente, string licencia)
        {
            this.cliente = cliente;
            this.licencia = licencia;
        }

        string DarLicencia(ICliente cliente, string licencia)
        {
            Random rnd = new Random();
            if (licencia == "maquinaria pesada")
            {
                if ( cliente.TipoCliente == "Empresa")
                {
                    int x = rnd.Next(0, 100);
                    if (x <= 63)
                    {
                        return "maquinaria pesada";
                    }
                    else
                    {
                        Console.Write("No se dio el permiso de maquinaria pesada");
                        return "";
                    }
                }
                else
                {
                    Console.Write("No se dio el permiso de maquinaria pesada");
                    return "";
                }
            }
            else
            {
                Console.Write("No se dio el permiso de maquinaria pesada");
                return "";
            }
            if (licencia == "buses")
            {
                if (cliente.TipoCliente == "Empresa")
                {
                    int x = rnd.Next(0, 100);
                    if (x <= 80)
                    {
                        return "buses";
                    }
                    else
                    {
                        Console.Write("No se dio el permiso para buses");
                        return "";
                    }
                }
                if (cliente.TipoCliente == "Organizacion")
                {
                    int x = rnd.Next(0, 100);
                    if (x <= 35)
                    {
                        return "buses";
                    }
                    else
                    {
                        Console.Write("No se dio el permiso para buses");
                        return "";
                    }
                }
                if (cliente.TipoCliente == "Institucion")
                {
                    int x = rnd.Next(0, 100);
                    if (x <= 58)
                    {
                        return "buses";
                    }
                    else
                    {
                        Console.Write("No se dio el permiso para buses");
                        return "";
                    }
                }
                else
                {
                    Console.Write("No se dio el permiso para buses");
                    return "";
                }
            }
            else
            {
                Console.Write("No se dio el permiso para buses");
                return "";
            }
        }
    }
}
