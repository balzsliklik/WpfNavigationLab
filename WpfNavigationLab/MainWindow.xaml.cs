using System.Configuration;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfNavigationLab
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Induláskor a főoldal jelenjen meg.
            mainFrame.Navigate(new HomePage());
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new HomePage());
        }

        private void Profile_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new ProfilePage());
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new SettingsPage());
        }

        private void OpenWindow_Click(object sender, RoutedEventArgs e)
        {
            InfoWindow infoWindow = new InfoWindow();
            infoWindow.Owner = this;
            infoWindow.Show();
        }

        private void OpenDialog_Click(object sender, RoutedEventArgs e)
        {
            InfoWindow infoWindow = new InfoWindow();
            infoWindow.Owner = this;
            infoWindow.ShowDialog();
        }

        private void HelpWindow_Click(object sender, RoutedEventArgs e)
        {
            HelpWindow helpWindow = new HelpWindow();
            helpWindow.Owner = this;
            helpWindow.ShowDialog();
        }
    }
}