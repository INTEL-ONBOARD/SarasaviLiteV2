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


namespace SarasaviLite
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

        private void exitApp(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SwitchCustomerPane(object sender, RoutedEventArgs e)
        {
            EmployeeLogin.Visibility = Visibility.Collapsed;
            CustomerLogin.Visibility = Visibility.Visible;
        }

        private void SwitchEmployeePane(object sender, RoutedEventArgs e)
        {
            EmployeeLogin.Visibility = Visibility.Visible;
            CustomerLogin.Visibility = Visibility.Collapsed;
        }

        private void goScan_Click(object sender, RoutedEventArgs e)
        {

        }

        private void backCusLoginView(object sender, RoutedEventArgs e)
        {
            CustomerSelector.Visibility = Visibility.Collapsed;
            CustomerLogin.Visibility= Visibility.Visible;   
        }

        private void backCusSelectView(object sender, RoutedEventArgs e)
        {
            CustomerPayment.Visibility = Visibility.Hidden;
            CustomerSelector.Visibility= Visibility.Visible;
        }
    }
}