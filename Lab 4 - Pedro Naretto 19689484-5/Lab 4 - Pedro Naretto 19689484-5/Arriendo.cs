using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4___Pedro_Naretto_19689484_5
{
    class Arriendo
    {
        public DateTime Inicio;
        public DateTime Final;
        public Sucursal sucursal;
        public Cliente cliente;
        public List<Vehiculos> vehiculos;

        public Arriendo(DateTime inicio, DateTime final, Sucursal sucursal, Cliente cliente, List<Vehiculos> vehiculos)
        {
            Inicio = inicio;
            Final = final;
            this.sucursal = sucursal;
            this.cliente = cliente;
            this.vehiculos = vehiculos;
        }
    }
}
