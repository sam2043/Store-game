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

namespace stor_steam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void closebutton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void gamestore_Click(object sender, RoutedEventArgs e)
        {
            this.gamestore.Background = Brushes.Transparent;
        }

        private void BUTTONSETTING_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.ShowDialog();
        }
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                DragMove();
            }
        }
    }
}
