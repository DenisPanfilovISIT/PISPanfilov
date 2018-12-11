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
using System.Drawing;
using System.Xml;
using System.IO;
using System.ComponentModel; // CancelEventArgs
using System.Data.SqlClient;
using System.Data.Common;

namespace Игра_ЗС
{
    /// <summary>
    /// Логика взаимодействия для Игра.xaml
    /// </summary>
    public partial class Игра : Window
    {
        public readonly Players people;
        public Игра()
        {
            Loaded += Игра_Loaded;
            InitializeComponent();
            textBox12.Text = 0.ToString();
            textBox13.Text = 0.ToString();
        }
        public Игра(Регистрация f)//Переопределяем объект игроки в форму3 для использования
         : this()
        {
            {
                people = f.people;
            }
        }

        private void Игра_Loaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Игрок " + people[0].Id + " | " + people[0].Name + " ходит первым");
        }
        bool f = false;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            ///закрытые коробки 7,8,9
            if (textBox9.Background == Brushes.Black && textBox10.Background == Brushes.Black && textBox11.Background == Brushes.Black)
            {
                textBox1.Text = random.Next(1, 7).ToString();
                textBox2.Text = 0.ToString();
                int die1 = Convert.ToInt32(textBox1.Text);
                int die2 = 0;
                Die die = new Die(die1, die2);
                textBox13.Text = die.SumDie().ToString();          
            }
            else
            {
                textBox1.Text = random.Next(1, 7).ToString();
                textBox2.Text = random.Next(1, 7).ToString();
                int die1 = Convert.ToInt32(textBox1.Text);
                int die2 = Convert.ToInt32(textBox2.Text);
                Die die = new Die(die1, die2);
                textBox13.Text = die.SumDie().ToString();
            }
            int tb = Convert.ToInt32(textBox13.Text);
        }
       
      
        public void ColorP(int iz, bool flag)
        {
            foreach (FrameworkElement txt in Grid2.Children)
            {
                if (txt is TextBox textBox)
                {
                    if (textBox.Text == iz.ToString())
                    {
                        textBox.Background = Brushes.White;
                        flag = false;
                    }
                }
            }
        }
        public void Zakr(int ost, int tb)
        {
            int[] t = new int[9];
            t[0] = Convert.ToInt32(textBox3.Text);
            t[1] = Convert.ToInt32(textBox4.Text);
            t[2] = Convert.ToInt32(textBox5.Text);
            t[3] = Convert.ToInt32(textBox6.Text);
            t[4] = Convert.ToInt32(textBox7.Text);
            t[5] = Convert.ToInt32(textBox8.Text);
            t[6] = Convert.ToInt32(textBox9.Text);
            t[7] = Convert.ToInt32(textBox10.Text);
            t[8] = Convert.ToInt32(textBox11.Text);
            //проверка на остаток
            if (ost == t[0] && textBox3.Background == Brushes.Black)
            {
                MessageBox.Show("Вы не можете закрыть коробку с номер " + ost);
                int iz = tb - t[0];
                ColorP(iz, flag1);
                int die1 = Convert.ToInt32(textBox1.Text);
                int die2 = Convert.ToInt32(textBox2.Text);
                Die die = new Die(die1, die2);
                textBox13.Text = die.SumDie().ToString();
                int tb12 = Convert.ToInt32(textBox12.Text) - iz;
                textBox12.Text = tb12.ToString();
                f = true;
            }
            if (ost == t[1] && textBox4.Background == Brushes.Black)
            {
                MessageBox.Show("Вы не можете закрыть коробку с номер " + ost);
                int iz = tb - t[1];
                ColorP(iz, flag2);
                int die1 = Convert.ToInt32(textBox1.Text);
                int die2 = Convert.ToInt32(textBox2.Text);
                Die die = new Die(die1, die2);
                textBox13.Text = die.SumDie().ToString();
                int tb12 = Convert.ToInt32(textBox12.Text) - iz;
                textBox12.Text = tb12.ToString();
                f = true;

            }
            if (ost == t[2] && textBox5.Background == Brushes.Black)
            {
                MessageBox.Show("Вы не можете закрыть коробку с номер " + ost);
                int iz = tb - t[2];
                ColorP(iz, flag3);
                int die1 = Convert.ToInt32(textBox1.Text);
                int die2 = Convert.ToInt32(textBox2.Text);
                Die die = new Die(die1, die2);
                textBox13.Text = die.SumDie().ToString();
                int tb12 = Convert.ToInt32(textBox12.Text) - iz;
                textBox12.Text = tb12.ToString();
                f = true;

            }
            if (ost == t[3] && textBox6.Background == Brushes.Black)
            {
                MessageBox.Show("Вы не можете закрыть коробку с номер " + ost);
                int iz = tb - t[3];
                ColorP(iz, flag4);
                int die1 = Convert.ToInt32(textBox1.Text);
                int die2 = Convert.ToInt32(textBox2.Text);
                Die die = new Die(die1, die2);
                textBox13.Text = die.SumDie().ToString();
                int tb12 = Convert.ToInt32(textBox12.Text) - iz;
                textBox12.Text = tb12.ToString();
                f = true;

            }
            if (ost == t[4] && textBox7.Background == Brushes.Black)
            {
                MessageBox.Show("Вы не можете закрыть коробку с номер " + ost);
                int iz = tb - t[4];
                ColorP(iz, flag5);
                int die1 = Convert.ToInt32(textBox1.Text);
                int die2 = Convert.ToInt32(textBox2.Text);
                Die die = new Die(die1, die2);
                textBox13.Text = die.SumDie().ToString();
                int tb12 = Convert.ToInt32(textBox12.Text) - iz;
                textBox12.Text = tb12.ToString();
                f = true;

            }
            if (ost == t[5] && textBox8.Background == Brushes.Black)
            {
                MessageBox.Show("Вы не можете закрыть коробку с номер " + ost);
                int iz = tb - t[5];
                ColorP(iz, flag6);
                int die1 = Convert.ToInt32(textBox1.Text);
                int die2 = Convert.ToInt32(textBox2.Text);
                Die die = new Die(die1, die2);
                textBox13.Text = die.SumDie().ToString();
                int tb12 = Convert.ToInt32(textBox12.Text) - iz;
                textBox12.Text = tb12.ToString();
                f = true;

            }
            if (ost == t[6] && textBox9.Background == Brushes.Black)
            {
                MessageBox.Show("Вы не можете закрыть коробку с номер " + ost);
                int iz = tb - t[6];
                ColorP(iz, flag7);
                int die1 = Convert.ToInt32(textBox1.Text);
                int die2 = Convert.ToInt32(textBox2.Text);
                Die die = new Die(die1, die2);
                textBox13.Text = die.SumDie().ToString();
                int tb12 = Convert.ToInt32(textBox12.Text) - iz;
                textBox12.Text = tb12.ToString();
                f = true;

            }
            if (ost == t[7] && textBox10.Background == Brushes.Black)
            {
                MessageBox.Show("Вы не можете закрыть коробку с номер " + ost);
                int iz = tb - t[7];
                ColorP(iz, flag8);
                int die1 = Convert.ToInt32(textBox1.Text);
                int die2 = Convert.ToInt32(textBox2.Text);
                Die die = new Die(die1, die2);
                textBox13.Text = die.SumDie().ToString();
                int tb12 = Convert.ToInt32(textBox12.Text) - iz;
                textBox12.Text = tb12.ToString();
                f = true;

            }
            if (ost == t[8] && textBox11.Background == Brushes.Black)
            {
                MessageBox.Show("Вы не можете закрыть коробку с номер " + ost);
                int iz = tb - t[8];
                ColorP(iz, flag9);
                int die1 = Convert.ToInt32(textBox1.Text);
                int die2 = Convert.ToInt32(textBox2.Text);
                Die die = new Die(die1, die2);
                textBox13.Text = die.SumDie().ToString();
                int tb12 = Convert.ToInt32(textBox12.Text) - iz;
                textBox12.Text = tb12.ToString();
                f = true;

            }
        }

     

        public void Null(int t5)
        {
            if (t5 == 0)
            {
                MessageBox.Show("Вы закончили ход. Бросьте заново кости.");
            }
        }

       
     

        int g = 0;
        private void button2_Click(object sender, EventArgs e)
        {
        }

        public void ColorIz()
        {
            //foreach (TextBox textBox in Grid2.Controls.OfType<TextBox>())
            foreach (FrameworkElement txt in Grid2.Children)
            {
                if (txt is TextBox textBox)
                {
                    textBox.Background = Brushes.White;
                    flag1 = false;
                    flag2 = false;
                    flag3 = false;
                    flag4 = false;
                    flag5 = false;
                    flag6 = false;
                    flag7 = false;
                    flag8 = false;
                    flag9 = false;
                }
            }
        }

        private void Form1_Closing(object sender, CancelEventArgs e)
        {
            Window form2 = new Регистрация();
            form2.Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox3_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {

        }
        bool flag1 = false;
        private void textBox3_MouseDoubleClick(object sender, MouseButtonEventArgs e) //закрытие коробок
        {
            if (Convert.ToInt32(textBox13.Text) <= 0)
            {
                MessageBox.Show("Бросьте кости!!!");
            }
            else
            {
                int tb = Convert.ToInt32(textBox13.Text);
                textBox3.Background = Brushes.Black;
                flag1 = true;
                int ch = Convert.ToInt32(textBox12.Text);

                int tb3 = Convert.ToInt32(textBox3.Text);
                int tb13 = Convert.ToInt32(textBox13.Text);
                Players Players = new Players(ch, tb3, tb13);
                textBox12.Text = Players.SumScget().ToString();
                textBox13.Text = Players.OstOchki().ToString();
                int t5 = Players.OstOchki();
                Zakr(t5, tb);
                Null(t5);
                if (f == false && t5 != 0)
                {
                    MessageBox.Show("Вы можете закрыть поле " + t5);
                }
            }
        }
        bool flag2 = false;
        private void textBox4_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (Convert.ToInt32(textBox13.Text) <= 0)
            {
                MessageBox.Show("Бросьте кости!!!");
            }
            else
            {
                Box box = new Box(flag2);
                if (textBox4.Background == Brushes.Black)
                {
                    MessageBox.Show("Коробка уже закрыта, закройте другую коробку");
                }
                else
                {
                    int tb4 = Convert.ToInt32(textBox4.Text);
                    int tb = Convert.ToInt32(textBox13.Text);
                    if (tb4 <= tb)
                    {
                        textBox4.Background = Brushes.Black;
                        int ch = Convert.ToInt32(textBox12.Text);
                        int tb13 = Convert.ToInt32(textBox13.Text);
                        Players Players = new Players(ch, tb4, tb13);
                        textBox12.Text = Players.SumScget().ToString(); textBox13.Text = Players.OstOchki().ToString();
                        flag2 = true;
                        int t5 = Players.OstOchki();
                        Zakr(t5, tb); Null(t5);
                        if (f == false && t5 != 0)
                        {
                            MessageBox.Show("Вы можете закрыть поле " + t5);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Вы не можете закрыть это поле");
                    }
                }
            }
        }
        bool flag3 = false;
        private void textBox5_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (Convert.ToInt32(textBox13.Text) <= 0)
            {
                MessageBox.Show("Бросьте кости!!!");
            }
            else
            {
                Box box = new Box(flag3);
                if (textBox5.Background == Brushes.Black)
                {
                    MessageBox.Show("Коробка уже закрыта, закройте другую коробку");
                }
                else
                {
                    int tb5 = Convert.ToInt32(textBox5.Text);
                    int tb = Convert.ToInt32(textBox13.Text);
                    int ch = Convert.ToInt32(textBox12.Text);
                    int tb13 = Convert.ToInt32(textBox13.Text);
                    if (tb5 <= tb)
                    {
                        textBox5.Background = Brushes.Black;

                        Players Players = new Players(ch, tb5, tb13);
                        textBox12.Text = Players.SumScget().ToString();
                        textBox13.Text = Players.OstOchki().ToString();
                        flag3 = true;
                        int t5 = Players.OstOchki();
                        Zakr(t5, tb); Null(t5);
                        if (f == false && t5 != 0)
                        {
                            MessageBox.Show("Вы можете закрыть поле " + t5);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Вы не можете закрыть это поле");
                    }

                }
            }
        }
        bool flag4 = false;
        private void textBox6_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (Convert.ToInt32(textBox13.Text) <= 0)
            {
                MessageBox.Show("Бросьте кости!!!");
            }
            else
            {
                Box box = new Box(flag4);
                if (textBox6.Background == Brushes.Black)
                {
                    MessageBox.Show("Коробка уже закрыта, закройте другую коробку");
                }
                else
                {
                    int tb6 = Convert.ToInt32(textBox6.Text);
                    int tb = Convert.ToInt32(textBox13.Text);
                    if (tb6 <= tb)
                    {
                        textBox6.Background = Brushes.Black;
                        int ch = Convert.ToInt32(textBox12.Text);
                        int tb13 = Convert.ToInt32(textBox13.Text);
                        Players Players = new Players(ch, tb6, tb13);
                        textBox12.Text = Players.SumScget().ToString();
                        textBox13.Text = Players.OstOchki().ToString();
                        flag4 = true;
                        int t5 = Players.OstOchki();
                        Zakr(t5, tb); Null(t5);
                        if (f == false && t5 != 0)
                        {
                            MessageBox.Show("Вы можете закрыть поле " + t5);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Вы не можете закрыть это поле");
                    }

                }
            }
        }
        bool flag5 = false;
        private void textBox7_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (Convert.ToInt32(textBox13.Text) <= 0)
            {
                MessageBox.Show("Бросьте кости!!!");
            }
            else
            {
                Box box = new Box(flag5);
                if (textBox7.Background == Brushes.Black)
                {
                    MessageBox.Show("Коробка уже закрыта, закройте другую коробку");
                }
                else
                {
                    int tb7 = Convert.ToInt32(textBox7.Text);
                    int tb = Convert.ToInt32(textBox13.Text);
                    if (tb7 <= tb)
                    {
                        textBox7.Background = Brushes.Black;
                        int ch = Convert.ToInt32(textBox12.Text);
                        int tb13 = Convert.ToInt32(textBox13.Text);
                        Players Players = new Players(ch, tb7, tb13);
                        textBox12.Text = Players.SumScget().ToString();
                        textBox13.Text = Players.OstOchki().ToString();
                        flag5 = true;
                        int t5 = Players.OstOchki();
                        Zakr(t5, tb); Null(t5);
                        if (f == false && t5 != 0)
                        {
                            MessageBox.Show("Вы можете закрыть поле " + t5);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Вы не можете закрыть это поле");
                    }

                }
            }
        }

        bool flag6 = false;
        private void textBox8_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (Convert.ToInt32(textBox13.Text) <= 0)
            {
                MessageBox.Show("Бросьте кости!!!");
            }
            else
            {
                Box box = new Box(flag6);
                if (textBox8.Background == Brushes.Black)
                {
                    MessageBox.Show("Коробка уже закрыта, закройте другую коробку");
                }
                else
                {
                    int tb8 = Convert.ToInt32(textBox8.Text);
                    int tb = Convert.ToInt32(textBox13.Text);
                    if (tb8 <= tb)
                    {
                        textBox8.Background = Brushes.Black;
                        int ch = Convert.ToInt32(textBox12.Text);
                        int tb13 = Convert.ToInt32(textBox13.Text);
                        Players Players = new Players(ch, tb8, tb13);
                        textBox12.Text = Players.SumScget().ToString(); textBox13.Text = Players.OstOchki().ToString();
                        flag6 = true;
                        int t5 = Players.OstOchki();
                        Zakr(t5, tb);
                        Null(t5);
                        if (f == false && t5 != 0)
                        {
                            MessageBox.Show("Вы можете закрыть поле " + t5);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Вы не можете закрыть это поле");
                    }
                }
            }
        }
        bool flag7 = false;
        private void textBox9_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (Convert.ToInt32(textBox13.Text) <= 0)
            {
                MessageBox.Show("Бросьте кости!!!");
            }
            else
            {
                Box box = new Box(flag7);
                if (textBox9.Background == Brushes.Black)
                {
                    MessageBox.Show("Коробка уже закрыта, закройте другую коробку");
                }
                else
                {
                    int tb9 = Convert.ToInt32(textBox9.Text);
                    int tb = Convert.ToInt32(textBox13.Text);
                    if (tb9 <= tb)
                    {
                        textBox9.Background = Brushes.Black;
                        int ch = Convert.ToInt32(textBox12.Text);
                        int tb13 = Convert.ToInt32(textBox13.Text);
                        Players Players = new Players(ch, tb9, tb13);
                        textBox12.Text = Players.SumScget().ToString(); textBox13.Text = Players.OstOchki().ToString();
                        flag7 = true;
                        int t5 = Players.OstOchki();
                        Zakr(t5, tb); Null(t5);
                        if (f == false && t5 != 0)
                        {
                            MessageBox.Show("Вы можете закрыть поле " + t5);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Вы не можете закрыть это поле");
                    }
                }
            }
        }
        bool flag8 = false;
        private void textBox10_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (Convert.ToInt32(textBox13.Text) <= 0)
            {
                MessageBox.Show("Бросьте кости!!!");
            }
            else
            {
                Box box = new Box(flag8);
                if (textBox10.Background == Brushes.Black)
                {
                    MessageBox.Show("Коробка уже закрыта, закройте другую коробку");
                }
                else
                {
                    int tb = Convert.ToInt32(textBox13.Text);
                    int tb10 = Convert.ToInt32(textBox10.Text);
                    if (tb10 <= tb)
                    {
                        textBox10.Background = Brushes.Black;
                        int ch = Convert.ToInt32(textBox12.Text);
                        int tb13 = Convert.ToInt32(textBox13.Text);
                        Players Players = new Players(ch, tb10, tb13);
                        textBox12.Text = Players.SumScget().ToString();
                        textBox13.Text = Players.OstOchki().ToString();
                        flag8 = true;
                        int t5 = Players.OstOchki();
                        Zakr(t5, tb); Null(t5);
                        if (f == false && t5 != 0)
                        {
                            MessageBox.Show("Вы можете закрыть поле " + t5);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Вы не можете закрыть это поле");
                    }

                }
            }
        }
        bool flag9 = false;
        private void textBox11_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (Convert.ToInt32(textBox13.Text) <= 0)
            {
                MessageBox.Show("Бросьте кости!!!");
            }
            else
            {
                Box box = new Box(flag9);
                if (textBox11.Background == Brushes.Black)
                {
                    MessageBox.Show("Коробка уже закрыта, закройте другую коробку");
                }
                else
                {
                    int tb = Convert.ToInt32(textBox13.Text);
                    int tb11 = Convert.ToInt32(textBox11.Text);
                    if (tb11 <= tb)
                    {
                        textBox11.Background = Brushes.Black;
                        int ch = Convert.ToInt32(textBox12.Text);
                        int tb13 = Convert.ToInt32(textBox13.Text);
                        Players Players = new Players(ch, tb11, tb13);
                        textBox12.Text = Players.SumScget().ToString();
                        textBox13.Text = Players.OstOchki().ToString();
                        flag9 = true;
                        int t5 = Players.OstOchki();
                        Zakr(t5, tb); Null(t5);
                        if (f == false && t5 != 0)
                        {
                            MessageBox.Show("Вы можете закрыть поле " + t5);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Вы не можете закрыть это поле");
                    }
                }
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)//завершить игру
        {
            int r = people.Length();

            people[g].Sum = Convert.ToInt32(textBox12.Text);

            MessageBox.Show("Игрок " + people[g].Id + " | " + people[g].Name + " набрал " + people[g].Sum + " очков");

            //SqlConnection sql = new SqlConnection(@"Data Source=DENISPANFILOV;Initial Catalog=GameZS;Integrated Security=True");
            //sql.Open();
            //SqlCommand sqlCommand = sql.CreateCommand();
            //sqlCommand.CommandText = "INSERT INTO Store";
            //int enq = sqlCommand.ExecuteNonQuery();
            //sql.Close();
            Window f4 = new Результаты(this);
            f4.Show();
            this.Hide();
        }



        private void button2_Click_1(object sender, RoutedEventArgs e)//передача хода
        {
            int r = people.Length();

                people[g].Sum = Convert.ToInt32(textBox12.Text);
           
            MessageBox.Show("Игрок " + people[g].Id + " | " + people[g].Name + " набрал " + people[g].Sum + " очков");
            //Vivod(g);
          
            g++;
            if (g < r)
            {
                MessageBox.Show("Ход передается игрок " + people[g].Id + " | " + people[g].Name);
            }
            textBox12.Text = 0.ToString();
            textBox13.Text = 0.ToString();
            textBox1.Text = 0.ToString();
            textBox2.Text = 0.ToString();
            ColorIz();
        }
    }
}
