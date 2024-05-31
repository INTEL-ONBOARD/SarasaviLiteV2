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
//<<<<<<< HEAD
using Microsoft.EntityFrameworkCore;
//=======
using SarasaviLite.Controller;
//>>>>>>> 5cc494f771ef3bf5ecd7d88d2104ffa8e0d195f8
using SarasaviLite.Data;
using SarasaviLite.Models;
using SarasaviLite.View;

namespace SarasaviLite
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        InventoryController inventoryController;

        int BookID = -1;

        public MainWindow()
        {
            InitializeComponent();

            inventoryController = new InventoryController();

            loadInitData();
            loaditemData();

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

            filter1.SelectedIndex = 0;
            filter2.SelectedIndex = 0;

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
           
        }   
        private void view_item(object sender, RoutedEventArgs e)
        {
            edit_view_stationary.Visibility = Visibility.Hidden;
            edit_view_book.Visibility = Visibility.Hidden;
            edit_view_voucher.Visibility = Visibility.Hidden;

            inventoryscrollView.Visibility = Visibility.Visible;

        }

        private void loadInitData()
        {
            var authors = inventoryController.GetAuthors();
            foreach (var author in authors)
            {
                selectBookAuthor.Items.Add(author.Name);
            }
        }

        private void loadDataForSelectionBoxes()
        {
            select_item_name.Items.Clear();

            var itemType = select_item_type.Text;
            if(itemType == "Book")
            {
            var books = inventoryController.GetBooks();
            foreach (var book in books)
            {
                select_item_name.Items.Add(book.Id +" - " + book.Title);
            }
            }
            else if(itemType == "Stationary")
            {
                var stationaries = inventoryController.GetStationaries();
                foreach (var stationary in stationaries)
                    select_item_name.Items.Add(stationary.Id +" - " + stationary.Type);
            }
            else
            {
            var vouchers = inventoryController.GetVouchers();
                foreach(var voucher in vouchers)
                    select_item_name.Items.Add(voucher.Id);
            }

        }

        private void loaditemData()
        {
            var items = inventoryController.GetItems();
            foreach (var item_ in items)
            {
                invItem inventory = new invItem();
                inventory.name = item_.Name;
                inventory.itemType = item_.ItemType;
                inventory.price = item_.Price.ToString();
                inventory.qty = item_.Qty.ToString();
                inventory.status = item_.Status;



                inventory.inventoryType = item_.InventoryType;
                inventory.location = item_.Location;
                inventory.itemCost = item_.ItemCost.ToString();
                inventory.tax = item_.Tax.ToString();
                inventory.discountAmount = item_.DiscountAmount.ToString();
                Console.WriteLine(inventory.name);
                View.Children.Add(inventory);
            }
        }

        private void save(object sender, RoutedEventArgs e)
        {
            var err = inventoryController.CreateBook(txtBookISBN.Text, txtBookTitle.Text, inventoryController.GetAuthors().FirstOrDefault(author => author.Name == selectBookAuthor.SelectedValue), txtBookYear.Text);
            if (err != "")
            {
                error_box_manage_content.Content = err;
                error_box_manage.Visibility = Visibility.Visible;
            }else{
                success_box_manage_content.Content = "Successfully creted a book item.";
                success_box_manage.Visibility = Visibility.Visible;
            }

            // show error message using your ui
        }

        private void select_item_type_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void saveStationary(object sender, RoutedEventArgs e)
        {
            var err = inventoryController.CreateStationary(select_stationary_distributer.Text, txt_stationary_type.Text);
            if (err != "")
            {
                error_box_manage_content.Content = err;
                error_box_manage.Visibility = Visibility.Visible;
            }
            else
            {
                success_box_manage_content.Content = "Successfully creted a stationary item.";
                success_box_manage.Visibility= Visibility.Visible;
            }
        }

        private void saveItem(object sender, RoutedEventArgs e)
        {
            var err = inventoryController.CreateItem(txt_price.Text, txt_cost.Text, select_inv_type.Text, select_item_location.Text, 
                txt_discount.Text, txt_tax.Text, txt_qty.Text, select_item_name.Text, select_item_type.Text, select_item_name.Text.Split(" - ")[0]);
            if (err != "")
            {
                error_box_manage_content.Content = err;
                error_box_manage.Visibility = Visibility.Visible;
            }
            else
            {
                success_box_manage_content.Content = "Successfully added an item to the inventory.";
                success_box_manage.Visibility = Visibility.Visible;
            }
        }

        private void select_item_type_DropDownClosed(object sender, EventArgs e)
        {
            if(select_item_type.Text != "")
                loadDataForSelectionBoxes();

        }
    }
}