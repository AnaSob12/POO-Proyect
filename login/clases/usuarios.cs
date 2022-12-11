using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login.clases
{
    class usuarios
    {
        private String USU_LOGIN;
        private String USU_PASS;


        public usuarios(string uSU_LOGIN, string uSU_PASS)
        {
            USU_LOGIN = uSU_LOGIN;
            USU_PASS = uSU_PASS;
        }
        public string CONSULTAR()
        {
            return ("SELECT * FROM USUARIO WHERE nombre ='" + this.USU_LOGIN + "' and CONTRASEÑA = dbo.MD5(" + this.USU_PASS + "')");
        }
    }
}
