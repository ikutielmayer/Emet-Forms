using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Emet_Forms
{
 
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();

          //  string connectionstring = "SERVER=localhost;DATABASE=emet;UID=ikutiel;PASSWORD=B7654321b;";
            string con = "server = localhost; user id = ikutiel; password = B7654321b; persistsecurityinfo = True; database = emet";
            MySqlConnection connection = new MySqlConnection(con);

            MySqlCommand cmd = new MySqlCommand("select * from reportes", connection);

            connection.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            connection.Close();
            
            dtGrid.DataContext = dt;

        }

        private void btnEnviar_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
