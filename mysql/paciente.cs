using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.mysql
{
    public class Paciente
    {
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string curp { get; set; }
        public string domicilio { get; set; }
        public string telefono { get; set; }
        public string fechaNac { get; set; }

        public Paciente() { }
        public Paciente(string nombre, string apellidoPaterno, string apellidoMaterno, string curp, string domicilio, string telefono, string fechaNac)
        {
            this.nombre = nombre;
            this.apellidoPaterno = apellidoPaterno;
            this.apellidoMaterno = apellidoMaterno;
            this.curp = curp;
            this.domicilio = domicilio;
            this.telefono = telefono;
            this.fechaNac = fechaNac;
            
        }
        
    }
}
