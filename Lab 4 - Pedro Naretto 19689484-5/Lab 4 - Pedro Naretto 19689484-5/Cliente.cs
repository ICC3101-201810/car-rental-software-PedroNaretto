using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4___Pedro_Naretto_19689484_5
{
    public abstract class Cliente
    {
        public string Nombre;
        public List<string> TipoLicencia;
        public List<Vehiculos> Compra;

        protected Cliente(string nombre, List<string> tipoLicencia, List<Vehiculos> compra)
        {
            Nombre = nombre;
            TipoLicencia = tipoLicencia;
            Compra = compra;
        }
    }
    class Empresa : Cliente
    {
        public Empresa(string nombre, List<string> tipoLicencia, List<Vehiculos> compra) : base(nombre, tipoLicencia, compra)
        {
        }
    }
    class Institucion : Cliente
    {
        public Institucion(string nombre, List<string> tipoLicencia, List<Vehiculos> compra) : base(nombre, tipoLicencia, compra)
        {
        }
    }
    class Organizacion : Cliente
    {
        public Organizacion(string nombre, List<string> tipoLicencia, List<Vehiculos> compra) : base(nombre, tipoLicencia, compra)
        {
        }
    }
    class Persona : Cliente
    {
        public Persona(string nombre, List<string> tipoLicencia, List<Vehiculos> compra) : base(nombre, tipoLicencia, compra)
        {
        }
    }
}
