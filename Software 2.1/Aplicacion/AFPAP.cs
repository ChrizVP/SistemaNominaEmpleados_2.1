using Dominio;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion
{
    public class AFPAP : Singleton<AFPAP>
    {
        public List<AFP> ListarAFP()
        {
            return AFPDA.Instancia.ListarAFP();
        }
    }
}