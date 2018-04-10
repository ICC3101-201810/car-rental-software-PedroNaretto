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
        public string patente;

        public Vehiculos(string tipo, string marca, string modelo, string año, string tipoLicencia, int precio, string patente)
        {
            this.tipo = tipo;
            this.marca = marca;
            this.modelo = modelo;
            this.año = año;
            TipoLicencia = tipoLicencia;
            this.precio = precio;
            this.patente = patente;
        }
    }
}
