using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4___Pedro_Naretto_19689484_5
{
    class Empresa:ICliente
    {
        public string nombreEmpresa;
        public string nombreRepresentante;
        public string tipoPermiso;


        public string TipoLicencia()
        {
            return tipoPermiso;
        }
    }
}
