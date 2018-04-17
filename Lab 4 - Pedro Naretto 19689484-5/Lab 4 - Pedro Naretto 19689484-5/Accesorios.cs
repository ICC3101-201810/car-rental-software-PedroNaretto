using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4___Pedro_Naretto_19689484_5
{
    public abstract class Accesorios
    {
        public virtual string Accesorio()
        {
            return "";
        }
    }

    class Electrico : Accesorios
    {
        public int Precio = 9000;


        public override string Accesorio()
        {
            return "Electrico";
        }
    }
    class MaleteroGrande : Accesorios
    {
        public int Precio = 9000;


        public override string Accesorio()
        {
            return "Maletero grande";
        }
    }

    class AsientosExtras : Accesorios
    {
        public int Precio = 9000;


        public override string Accesorio()
        {
            return "Corrida de asientos extra";
        }
    }

    class DVD : Accesorios
    {
        public int Precio = 9000;


        public override string Accesorio()
        {
            return "DVD";
        }
    }

    class Bluetooth:Accesorios
    {
        public int Precio = 9000;


        public override string Accesorio()
        {
            return "Radio con Bluetooth";
        }
    }

    class GPS:Accesorios
    {
        public int Precio = 9000;

        public override string Accesorio()
        {
            return "GPS";
        }
    }

    class RuedaRepuesto:Accesorios
    {
        public int Precio = 9000;

        public override string Accesorio()
        {
            return "Rueda de repuesto";
        }
    }

    class CortinaVentanas:Accesorios
    {
        public int Precio = 9000;

        public override string Accesorio()
        {
            return "Cortinas para ventanas";
        }
    }

    class SillaInfante:Accesorios
    {
        public int Precio = 9000;

        public override string Accesorio()
        {
            return "Silla para infante";
        }
    }
}
