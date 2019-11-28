using Dominio;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion
{
    public class UsuarioAP:Singleton<UsuarioAP>
    {
        public bool IniciarSesion(Usuario usuario)
        {
            Usuario usuarioretorno = UsuarioDA.Instancia.IniciarSesion(usuario);
            if (usuarioretorno.Id_Usuario > 0) return true;
            else return false;
        }
    }
}
