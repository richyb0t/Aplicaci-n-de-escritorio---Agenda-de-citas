using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.mysql
{
    public class Expediente
    {
        public string nombreD { get; set; }
        public string nombreP { get; set; }
        public string apellidoPaternoP { get; set; }
        public string apellidoMaternoP { get; set; }
        public string curpP { get; set; }
        public string domicilioP { get; set; }
        public string telefonoP { get; set; }
        public string fechaNacP { get; set; }
        public string padecimiento { get; set; }
        public string comentario { get; set; }

        public Expediente() { }
        public Expediente(string nombreD, string nombreP, string apellidoPaternoP, string apellidoMaternoP, string curpP, string domicilioP, string telefonoP, string fechaNacP, string padecimiento, string comentario)
        {
            this.nombreD = nombreD;
            this.nombreP = nombreP;
            this.apellidoPaternoP = apellidoPaternoP;
            this.apellidoMaternoP = apellidoMaternoP;
            this.curpP = curpP;
            this.domicilioP = domicilioP;
            this.telefonoP = telefonoP;
            this.fechaNacP = fechaNacP;
            this.padecimiento = padecimiento;
            this.comentario = comentario;
        }
    }
}
