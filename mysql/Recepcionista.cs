using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.mysql
{
    public class Recepcionista
    {

        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string curp { get; set; }
        public string domicilio { get; set; }
        public string telefono { get; set; }
        public string fechaNac { get; set; }
        public string fechaIng { get; set; }

        public Recepcionista() { }
        public Recepcionista(string nombre, string apellidoPaterno, string apellidoMaterno, string curp, string domicilio, string telefono, string fechaNac, string fechaIng)
        {
            this.nombre = nombre;
            this.apellidoPaterno = apellidoPaterno;
            this.apellidoMaterno = apellidoMaterno;
            this.curp = curp;
            this.domicilio = domicilio;
            this.telefono = telefono;
            this.fechaNac = fechaNac;
            this.fechaIng = fechaIng;
        }
    }
}

       