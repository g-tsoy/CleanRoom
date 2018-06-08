using Core;
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

namespace RoomCleaning
{
    /// <summary>
    /// Логика взаимодействия для Schedule.xaml
    /// </summary>
    public partial class Schedule : Window
    {
        public Schedule()
        {
            InitializeComponent();
            schGrid.ShowGridLines = true;
            


            GridLength gl = new GridLength(1, GridUnitType.Star);
            //ColumnDefinition cd;
            //for (int w = 0; w < 7; w++)
            //{
            //    cd = new ColumnDefinition();
            //    cd.Width = gl;
            //    schGrid.ColumnDefinitions.Add(cd);
            //}
            //RowDefinition rd;
            //for (int h = 0; h < 3; h++)
            //{
            //    rd = new RowDefinition();
            //    rd.Height = gl;
            //    schGrid.RowDefinitions.Add(rd);
            //}

            Button newButton = new Button();
            Grid.SetColumn(newButton, 1);
            Grid.SetRow(newButton, 1);
            schGrid.Children.Add(newButton);

            //string[] result = Algorithm.WhoWillCleanToday();

            //A_1.ItemsSource = result[0];
            //A_2.ItemsSource = result[1];
            //A_1.ItemsSource = result[2];
            //AT.ItemsSource = result[3];
            //A1.ItemsSource = result[4];
            //A2.ItemsSource = result[5];
            //A3.ItemsSource = result[6];

            //B_3.ItemsSource = result[7];
            //B_2.ItemsSource = result[8];
            //B_1.ItemsSource = result[9];
            //BT.ItemsSource = result[10];
            //B1.ItemsSource = result[11];
            //B2.ItemsSource = result[12];
            //B3.ItemsSource = result[13];

            //C_3.ItemsSource = result[14];
            //C_2.ItemsSource = result[15];
            //C_1.ItemsSource = result[16];
            //CT.ItemsSource = result[17];
            //C1.ItemsSource = result[18];
            //C2.ItemsSource = result[19];
            //C3.ItemsSource = result[20];
        }
    }
}
