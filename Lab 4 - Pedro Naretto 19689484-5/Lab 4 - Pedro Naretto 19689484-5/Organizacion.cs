using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4___Pedro_Naretto_19689484_5
{
    class Organizacion:ICliente
    {
        public string nombreOrganizacion;
        public string nombreRepresentante;
        public string tipoPermiso;

        public Organizacion(string nombreOrganizacion, string nombreRepresentante, string tipoPermiso)
        {
            this.nombreOrganizacion = nombreOrganizacion;
            this.nombreRepresentante = nombreRepresentante;
            this.tipoPermiso = tipoPermiso;
        }

        public string TipoCliente()
        {
            return "Organizacion";
        }

        public string TipoLicencia()
        {
            return tipoPermiso;
        }
    }
}
