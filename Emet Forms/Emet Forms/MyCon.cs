using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emet_Forms
{
    public class MyCon
    {
        public static MySqlConnection ObtenerConexion()
        {
            string con = "server=localhost; user id = ikutiel; password = B7654321b; persistsecurityinfo = True; database = emet";
            MySqlConnection conectar = new MySqlConnection(con);

            conectar.Open();

            return conectar;
        }
    }
}
