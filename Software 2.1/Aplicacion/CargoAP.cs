using Dominio;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion
{
    public class CargoAP:Singleton<CargoAP>
    {
        public List<Cargo> ListarCargo()
        {
            return CargoDA.Instancia.ListarCargo();
        }
    }
}
