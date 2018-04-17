using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4___Pedro_Naretto_19689484_5
{
    public abstract class Vehiculos
    {
        public string Marca;
        public string Modelo;
        public int Año;
        public int Precio;
        public string Patente;
        public int Stock;
        public List<Accesorios> Accesorios;

        protected Vehiculos(string marca, string modelo, int año, int precio, string patente, int stock, List<Accesorios> accesorios)
        {
            Marca = marca;
            Modelo = modelo;
            Año = año;
            Precio = precio;
            Patente = patente;
            Stock = stock;
            Accesorios = accesorios;
        }

        public List<Accesorios> AgregarAccesorio(List<Accesorios> accesorios)
        {
            List<Accesorios> AccesosiosVehiculo = new List<Accesorios> { };
            List<Accesorios> accesorios2 = accesorios.Where(x => x is Accesorios).ToList();

            while (true)
            {
                int Respuesta;
                Console.WriteLine("Tenemos estos accesorios para ofrecerle:\n 0)Nada");
                int x = 1;
                foreach (Accesorios accesorio in accesorios2)
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
                    foreach (Accesorios accesorio in accesorios2)
                    {
                        Console.WriteLine($"{x}){accesorio.Accesorio()}");
                    }
                    respuestaS = Console.ReadLine();
                }
                int.TryParse(respuestaS, out Respuesta);
                if (Respuesta != 0)
                {
                    AccesosiosVehiculo.Add(accesorios2[Respuesta - 1]);
                    accesorios2.Remove(accesorios2[Respuesta - 1]);
                }
                else if (Respuesta == 0)
                {
                    break;
                }
            }
            return AccesosiosVehiculo;
        }
    }
    class Autos : Vehiculos
    {
        string TipoLicencia = "Licencia para autos";

        public Autos(string marca, string modelo, int año, int precio, string patente, int stock, List<Accesorios> Accesorios) : base(marca, modelo, año, precio, patente, stock, Accesorios)
        {
        }

    }
    class Camion : Vehiculos
    {
        string TipoLicencia = "Licencia para camiones";

        public Camion(string marca, string modelo, int año, int precio, string patente, int stock, List<Accesorios> Accesorios) : base(marca, modelo, año, precio, patente, stock, Accesorios)
        {
        }
    }
    class Buses : Vehiculos
    {
        string TipoLicencia = "Licencia para buses";

        public Buses(string marca, string modelo, int año, int precio, string patente, int stock, List<Accesorios> Accesorios) : base(marca, modelo, año, precio, patente, stock, Accesorios)
        {
        }
    }
}
