
using System.Data;
using System.Windows;
using MySql.Data.MySqlClient;

namespace Emet_Forms
{
 
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();

            //  string connectionstring = "SERVER=localhost;DATABASE=emet;UID=ikutiel;PASSWORD=B7654321b;";


            obtenerLista();




        }

        private void obtenerLista() {
            MySqlConnection con = MyCon.ObtenerConexion();

            MySqlCommand cmd = new MySqlCommand("select * from reportes", con);

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();

            dtGrid.DataContext = dt;
        }

        private void btnEnviar_Click(object sender, RoutedEventArgs e)
        {            
            Reportar pReporte = new Reportar();
            pReporte.serial = txSerial.Text.Trim();
            pReporte.makat = txMakat.Text.Trim();
            pReporte.Paka = txPaka.Text.Trim();

            //  pReporte.Fecha_Nac = dtpFechaNacimiento.Value.Year + “/” +dtpFechaNacimiento.Value.Month + “/” +dtpFechaNacimiento.Value.Day;

            int resultado = ReportesABM.Agregar(pReporte);

            if (resultado > 0)
            {
                MessageBox.Show("Se ha enviado con Exito!!", "Guardado", MessageBoxButton.OK, MessageBoxImage.Information);

                obtenerLista();
            }

            else

            {
                MessageBox.Show("No se pudo guardar el Reporte", "Fallo!!", MessageBoxButton.OK, MessageBoxImage.Exclamation);

            }

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
          
        }
    }
}
