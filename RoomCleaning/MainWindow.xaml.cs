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

namespace RoomCleaning
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            int a;
        }

        private void ButtonClickEnterYourRoom(object sender, RoutedEventArgs e)
        {
            Schedule window = new Schedule();
            window.ShowDialog();
        }

        private void ButtonClickRegistrateUser(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonClickRegistrateRoom(object sender, RoutedEventArgs e)
        {

        }
    }
}
