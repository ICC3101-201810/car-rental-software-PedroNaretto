using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4___Pedro_Naretto_19689484_5
{
    class Institucion:ICliente
    {
        public string nombreInstitucion;
        public string nombreRepresentante;
        public string tipoPermiso;

        public Institucion(string nombreInstitucion, string nombreRepresentante, string tipoPermiso)
        {
            this.nombreInstitucion = nombreInstitucion;
            this.nombreRepresentante = nombreRepresentante;
            this.tipoPermiso = tipoPermiso;
        }

        public string TipoLicencia()
        {
            return tipoPermiso;
        }
    }
}
