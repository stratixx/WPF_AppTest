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

namespace WpfAppTest
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonMoveClick(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("ButtonMoveClick");
        }

        private void ButtonSettingsClick(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("ButtonSettingsClick");
        }

        private void ButtonReadClick(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("ButtonReadClick");
        }

        private void Button4Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Button4Click");
        }
    }
}
