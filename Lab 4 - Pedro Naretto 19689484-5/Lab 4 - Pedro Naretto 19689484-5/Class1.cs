using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4___Pedro_Naretto_19689484_5
{
    class Vehiculos
    {
        public string tipo;
        public string marca;
        public string modelo;
        public string año;
        public string TipoLicencia;
        public int precio;

        public Vehiculos(string tipo, string marca, string modelo, string año, string TipoLicencia, int precio)
        {
            this.tipo = tipo;
            this.marca = marca;
            this.modelo = modelo;
            this.año = año;
            this.TipoLicencia = TipoLicencia;
            this.precio = precio;
        }
    }
}
