using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4___Pedro_Naretto_19689484_5
{
    class Persona:ICliente
    {
        public string nombre;
        public int edad;
        public string Licencia;

        public Persona(string nombre, int edad, string licencia)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.Licencia = licencia;
        }

        public TipoCliente()
        {
            return "Persona";
        }

        public string TipoLicencia()
        {
            return Licencia;
        }
    }
}
