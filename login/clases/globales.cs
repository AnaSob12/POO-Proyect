using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.clases
{
    public static class globales
    {

        static public string dbn = "SISTEMA_VENTAS";
        static public string server = "LAPTOP-S99HO669";
        static public string password = "321654a";
        static public string seguridad = "Integrated Security=True";
        static public string userID = "sa";

        static public string UserID = "sa";

        static public string miconexion = @"Data Source = " + server + "; Initial Catalog = " + dbn + "; Persist Security Info = True; User ID = sa; Password = " + password;
    }
}
