using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4___Pedro_Naretto_19689484_5
{
    class Persona:Cliente
    {
        string nombre;
        int edad;
        string Licencia;

        public Persona(string nombre, int edad, string licencia)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.Licencia = licencia;
        }

        public string tipoLicencia()
        {
            return Licencia;
        }
    }
}
