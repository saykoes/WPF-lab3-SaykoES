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

        /// <summary>
        /// Close Program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        /// <summary>
        /// Developer info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sayko Egor, 2024");
        }

        /// <summary>
        /// Changing colors
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Color_Click(object sender, RoutedEventArgs e)
        {
            var radio = (sender as System.Windows.Controls.Primitives.ButtonBase);
            string btnContent = radio.Content.ToString().TrimStart('_');
            
            if (btnContent == "Red")
                mainMenu.Background = Brushes.Red;
            if (btnContent == "Yellow")
                mainMenu.Background = Brushes.Yellow;
            if (btnContent == "Blue")
                mainMenu.Background = Brushes.Blue;
            if (btnContent == "Green")
                mainMenu.Background = Brushes.Green;
        }

        /// <summary>
        /// Status Bar info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_MouseEnter(object sender, MouseEventArgs e)
        {
            var btn = (sender as System.Windows.Controls.Primitives.ButtonBase);
            string btnContent = btn.Content.ToString().TrimStart('_');
            if (btnContent == "Yellow" || btnContent == "Red" || btnContent == "Green" || btnContent == "Blue")
                StatusText.Text = "Make it " + btnContent + "!";
            else if (btnContent == "Close") StatusText.Text = "Exits the program";
            else if (btnContent == "About") StatusText.Text = "Developer info";
        }

        /// <summary>
        /// Status Bar info for MenuItem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_MouseEnter(object sender, MouseEventArgs e)
        {
            var btn = (sender as System.Windows.Controls.MenuItem);
            string btnContent = btn.Header.ToString();
            if (btnContent == "_Close") StatusText.Text = "Exits the program";
            else if(btnContent == "_About") StatusText.Text = "Developer info";
        }
    }
}
