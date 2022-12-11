using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.clases
{
    class generales
    {
        private string Nombre;
        private string Direccion;
        private string Telefono;
        private string Gerente;

        public generales(string Nombre, string Direccion, string Telefono, string Gerente)
        {
            this.Nombre = Nombre;
            this.Direccion = Direccion;
            this.Telefono = Telefono;
            this.Gerente = Gerente;
        }

        public generales(string Nombre)
        {
            this.Nombre = Nombre;
        }

        public generales()
        {

        }

        public string GRABAR()
        {
            return (" insert into generales values ('" + this.Nombre + "','" + this.Direccion + "','" + this.Telefono + "','" + this.Gerente + "')");
        }
        public string CONSULTARI()
        {
            return (" SELECT * FROM  generales WHERE Nombre = '" + this.Nombre + "'" );
        }
        public string modificar()
        {
            return (" update generales set  direcion ='" + this.Direccion + "', Telefono ='" + this.Telefono + "', Gerente ='" + this.Gerente + "' WHERE Nombre = '" + this.Nombre + "'" );
        }
        public string consultageneral()
        {
            return (" SELECT Nombre as Nombre , Direccion as Direccion, Telefono as Telefono, Gerente as Gerente FROM  generales");
        }
        /*public string consecutivo()
        {
            return ("select count(*) as folio from generales");
        }*/
    }
}
