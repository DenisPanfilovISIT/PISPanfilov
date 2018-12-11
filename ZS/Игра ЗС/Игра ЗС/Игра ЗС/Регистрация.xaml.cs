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

namespace Игра_ЗС
{
    /// <summary>
    /// Логика взаимодействия для Регистрация.xaml
    /// </summary>
    public partial class Регистрация : Window
    {
        public Players people = new Players();
        public Регистрация()
        {
            InitializeComponent();
            ch = 1;
        }
        static int ch;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int r = people.Length();
            // textBox1.Clear();
            bool unik = true;
            //Проверка на пустые строки
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите имя игрока");
            }
            else//Заполнение объекта Игроки данными
            {
                string name = textBox1.Text;

                //bool check = false;
                //if (ch == 1)
                //{
                //    check = true;
                //}
                //else
                //{
                //    check = false;
                //}
                for (int i = 0; i < people.Length(); i++)
                {
                    if (people[i].Name == name)
                    {
                        MessageBox.Show("Такое имя уже занято!");
                        unik = false;
                    }

                }
                if (unik)
                {
                    int sum = 0;
                    people.AddPlayer(ch, name, sum);
                    textBox3.Text = ch.ToString();
                    textBox2.Text = "Игрок " + name + " добавлен!";
                    ch++;
                }
            }
            textBox1.Clear();
        }

      /*  private void Form3_Load(object sender, EventArgs e)
        {
            ch = 1;
        }*/

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window form3 = new Игра(this);
            form3.Show();
            this.Hide();
        }
    }
}
