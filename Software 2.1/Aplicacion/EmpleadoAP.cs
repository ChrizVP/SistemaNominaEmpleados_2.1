using Dominio;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion
{
    public class EmpleadoAP:Singleton<EmpleadoAP>
    {
        public Empleado BuscarEmpleado(String DNI)
        {
            return EmpleadoDA.Instancia.BuscarEmpleado(DNI);
        }
    }
}
