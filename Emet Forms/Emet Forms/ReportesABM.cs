using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Emet_Forms
{
    class ReportesABM
    {

        public static int Agregar(Reportar pReporte)
        {
            int retorno = 0;
            
            string pFecha = DateTime.Now.Year.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Day.ToString();
            string pUser = "1";
            string pHora = DateTime.Now.TimeOfDay.Hours.ToString() + ":" + DateTime.Now.TimeOfDay.Minutes.ToString();

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into reportes(userid,fecha,hora,serial,makat,paka) values('{0}','{1}','{2}','{3}','{4}','{5}')", pUser,pFecha,pHora,pReporte.serial, pReporte.makat, pReporte.Paka), MyCon.ObtenerConexion());

            try
            {
                retorno = comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
            
                throw;
            }
          

            return retorno;

        }

    }
}
