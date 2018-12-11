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
using System.Xml;
using System.Data;
using System.Data.SqlClient;

namespace Игра_ЗС
{
    /// <summary>
    /// Логика взаимодействия для Результаты.xaml
    /// </summary>
    public partial class Результаты : Window
    {
        public readonly Players people;
        public Результаты()
        {
            InitializeComponent();
        }
        public Результаты(Игра f)//Переопределяем объект игроки в форму для использования
      : this()
        {
            {
                people = f.people;
            }
        }



        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            for (int i = 0; i < people.Length(); i++)
            {
                RichTextBox1.AppendText("Игрок " + people[i].Name + " набрал " + people[i].Sum + " очков" + "\n");       
            }

            var array = new int[0];
            var pobeditel = Pobed(0, 0, array);
           
            RichTextBox1.Clear();
            for (int i = 0; i < people.Length(); i++)
            {
                RichTextBox1.AppendText("Игрок " + people[i].Name + " набрал " + people[i].Sum + " очков" + "\n");
            }

            TextBox1.Text = "Игрок " + pobeditel + " победил";
            Single single = new Single();
            try
            {
                single.Addbd(people);
            }
            catch
            {
                MessageBox.Show("Нет соединения");
            }
        }

        public string Pobed(int n, int max, int[] array)
        {
            //people[1].Sum = 5;
            //people[0].Sum = 5;
            //people[2].Sum = 5;
            while (true)
            {
                
                string Pobed = "0";
                Random rnd = new Random();
                array = new int[people.Length()];
                max = people[0].Sum;
                array[0] = max;
                for (int i = 1; i < people.Length(); i++)
                {
                    if (max < people[i].Sum)
                    {
                        max = people[i].Sum;
                        array[i] = max;
                        for (int j = 0; j < i; j++)
                        {
                            array[j] = 0;
                        }
                    }
                    if (max == people[i].Sum)
                    {
                        max = people[i].Sum;
                        array[i] = max;
                    }
                }
                n = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == 0) continue;
                    {
                        n++;
                        Pobed = people[i].Name;
                    }
                }
                if (n > 1)
                {
                    for (var i = 0; i < array.Length; i++)
                    {
                        if (array[i] == 0) continue;
                        array[i] += rnd.Next(1, 7);
                        people[i].Sum = array[i];
                        MessageBox.Show("Игрок " + people[i].Name + " сделал дополнительный бросок(ничейный исход)");

                    }
                    
                    n = 0;
                    max = 0;
                    array = new int[0];
                }
                else
                {
                    return Pobed;
                }
              
            }
        }
    }
}

   
    
 

