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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;

namespace Игра_ЗС
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window form2 = new Регистрация();
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
           
            
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Reiting add = new Reiting();
            add.ShowDialog();
            this.Visibility = Visibility.Hidden;
        }
    }
}
