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
