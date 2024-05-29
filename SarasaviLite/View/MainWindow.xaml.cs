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
using SarasaviLite.Controller;
using SarasaviLite.Data;
using SarasaviLite.Models;


namespace SarasaviLite
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        InventoryController inventoryController;

        public MainWindow()
        {
            InitializeComponent();

            inventoryController = new InventoryController();

            loadInitData();
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
            CustomerLogin.Visibility = Visibility.Visible;
        }

        private void backCusSelectView(object sender, RoutedEventArgs e)
        {
            CustomerPayment.Visibility = Visibility.Hidden;
            CustomerSelector.Visibility = Visibility.Visible;
        }



        private void add_item(object sender, RoutedEventArgs e)
        {
            inventoryscrollView.Visibility = Visibility.Hidden;
        }
        private void recheck(object sender, TextChangedEventArgs e)
        {

        }

        private void Add_action(object sender, RoutedEventArgs e)
        {

        }
        
        private void clear_Action(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void add_voucher(object sender, RoutedEventArgs e)
        {
            edit_view_stationary.Visibility = Visibility.Hidden;
            edit_view_book.Visibility = Visibility.Hidden;
            edit_view_voucher.Visibility = Visibility.Visible;
            
            inventoryscrollView.Visibility = Visibility.Hidden;
        }

        private void add_stationary(object sender, RoutedEventArgs e)
        {
            edit_view_stationary.Visibility = Visibility.Visible;
            edit_view_book.Visibility = Visibility.Hidden;
            edit_view_voucher.Visibility = Visibility.Hidden;
            
            inventoryscrollView.Visibility = Visibility.Hidden;

        }

        private void add_book(object sender, RoutedEventArgs e)
        {
            edit_view_stationary.Visibility = Visibility.Hidden;
            edit_view_book.Visibility = Visibility.Visible;
            edit_view_voucher.Visibility = Visibility.Hidden;
            
            inventoryscrollView.Visibility = Visibility.Hidden;
        }

        private void voucher_type__SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


        private void inventoryViewAction(object sender, RoutedEventArgs e)
        {
            Home_view.Visibility = Visibility.Hidden;
            add_view.Visibility= Visibility.Hidden;
            search_view.Visibility= Visibility.Hidden;
            report_view.Visibility=Visibility.Hidden;
            inventory_view.Visibility=Visibility.Visible;

            inventoryscrollView.Visibility = Visibility.Visible;
            edit_view_stationary.Visibility = Visibility.Hidden;
            edit_view_book.Visibility = Visibility.Hidden;
            edit_view_voucher.Visibility = Visibility.Hidden;

        }

        private void dashboardViewAction(object sender, RoutedEventArgs e)
        {
            inventory_view.Visibility = Visibility.Hidden;
            Home_view.Visibility = Visibility.Visible;
            add_view.Visibility = Visibility.Hidden;
            search_view.Visibility = Visibility.Hidden;
            report_view.Visibility = Visibility.Hidden;

        }

        private void searchViewAction(object sender, RoutedEventArgs e)
        {
            inventory_view.Visibility = Visibility.Hidden;
            Home_view.Visibility = Visibility.Hidden;
            add_view.Visibility = Visibility.Hidden;
            search_view.Visibility = Visibility.Visible;
            report_view.Visibility = Visibility.Hidden;


        }

        private void addViewAction(object sender, RoutedEventArgs e)
        {
            inventory_view.Visibility = Visibility.Hidden;
            Home_view.Visibility = Visibility.Hidden;
            add_view.Visibility = Visibility.Visible;
            search_view.Visibility = Visibility.Hidden;
            report_view.Visibility = Visibility.Hidden;


        }

        private void reportViewAction(object sender, RoutedEventArgs e)
        {
            inventory_view.Visibility = Visibility.Hidden;
            Home_view.Visibility = Visibility.Hidden;
            add_view.Visibility = Visibility.Hidden;
            search_view.Visibility = Visibility.Hidden;
            report_view.Visibility = Visibility.Visible;

        }



        private void btnAddBook_Click(object sender, RoutedEventArgs e)
        {
            Book book = new Book()
            {
                ISBN = Convert.ToInt32(txtBookISBN.Text),
                Title = txtBookTitle.Text,
                Author = inventoryController.GetAuthors().FirstOrDefault(author => author.Name == selectBookAuthor.SelectedValue),
                Year = Convert.ToInt32(txtBookYear.Text)
            };
            inventoryController.SaveBook(book);
        }

        private void loadInitData()
        {
            var authors = inventoryController.GetAuthors();
            foreach (var author in authors)
            {
                selectBookAuthor.Items.Add(author.Name);
            }
        }
    }
}