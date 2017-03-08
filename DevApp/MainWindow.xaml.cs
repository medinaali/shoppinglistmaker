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
using DevApp.Entities;

namespace DevApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private void btnNewWindow_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new SecondWindow();
            newWindow.Show();
        }

        private void btnNewWindow2_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new Form1();
            newWindow.Show();
        }
    }
}
