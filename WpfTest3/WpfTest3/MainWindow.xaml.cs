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

namespace WpfTest3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Close_MenuItem_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void rbColor_Click(object sender, RoutedEventArgs e)
        {
            var radio = (sender as RadioButton);
            string radioName = radio.Name;
            
            if (radioName == "rbRed")
                mainMenu.Background = Brushes.Red;
            if (radioName == "rbYellow")
                mainMenu.Background = Brushes.Yellow;


        }
    }
}
