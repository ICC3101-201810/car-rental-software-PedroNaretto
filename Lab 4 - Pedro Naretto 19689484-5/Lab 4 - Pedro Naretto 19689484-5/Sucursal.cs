using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4___Pedro_Naretto_19689484_5
{
    class Sucursal
    {
        public List<Vehiculos> listaVehiculos;
        public string ubicacion;

        public Sucursal(List<Vehiculos> listaVehiculos, string ubicacion)
        {
            this.listaVehiculos = listaVehiculos;
            this.ubicacion = ubicacion;
        }
    }
}
