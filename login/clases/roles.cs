using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login.clases
{
    class roles
    {
        public string GRABAR()
        {
            return (" insert into Rol values ('" + this.id + "','" + this.nombre + "')");
        }
        public string consultar()
        {
            return (" SELECT * FROM  Rol WHERE IDROL= '" + this.id + "'");
        }
        public string modificar()
        {
            return (" update Rol set  DESCRIPCION ='" + this.nombre + "' WHERE IDROL = '" + this.id + "'");
        }
        public string ConsultaGeneral()
        {
            return (" SELECT IDROL as IDROL , DESCRIPCION as DESCRIPCION FROM  ROL");

        }

        public string consecutivo()
        {
            return ("");

        }
    }
}
