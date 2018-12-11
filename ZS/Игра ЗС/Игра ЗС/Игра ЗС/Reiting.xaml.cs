using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace Игра_ЗС
{
    /// <summary>
    /// Логика взаимодействия для Reiting.xaml
    /// </summary>
    public partial class Reiting : Window
    {
        public Reiting()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            var connection =
                    @"Data Source=DENISPANFILOV;Initial Catalog=Game;Integrated Security=True";
            var sqlExp = "sp_SelectUsers";
            using (var con = new SqlConnection(connection))
            {
                con.Open();
                var command = new SqlCommand(sqlExp, con)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                var reader = command.ExecuteReader();
                var table = new DataTable();
                try
                {
                    if (reader.HasRows)
                    {
                        table.Load(reader);
                    }
                    dataGrid.ItemsSource = table.DefaultView;
                }
                catch
                {
                    MessageBox.Show("Ошибка");
                }
               
                reader.Close();
            }
        }
    }
}
