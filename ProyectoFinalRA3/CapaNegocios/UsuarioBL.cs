using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato;
using ClassLibrary1;

namespace CapaNegocios
{
    public class UsuarioBL
    {
        UsuarioDAL dal = new UsuarioDAL();

        public UsuarioDTO Login(string user, string pass)
        {
            // VALIDACIONES

            if (string.IsNullOrWhiteSpace(user))
                throw new Exception("Debe ingresar el usuario");

            if (string.IsNullOrWhiteSpace(pass))
                throw new Exception("Debe ingresar la contraseña");

            return dal.Login(user, pass);
        }
    }
}
