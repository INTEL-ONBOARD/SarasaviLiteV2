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

namespace SarasaviLite.View
{
    /// <summary>
    /// Interaction logic for invItem.xaml
    /// </summary>
    public partial class invItem : UserControl
    {
        MainWindow main;
        public invItem(MainWindow mainWindow)
        {
            InitializeComponent();
            this.DataContext = this;
            this.main = mainWindow;
        }

        public int Id { get; set; }
        public String itemType { get; set; }
        public String name { get; set; }
        public String price { get; set; }
        public String qty { get; set; }
        public String status { get; set; }
        public String inventoryType { get; set; }
        public String location { get; set; }
        public String itemCost { get; set; }
        public String tax { get; set; }
        public String discountAmount { get; set; }
        
        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            main.DeleteItem(Id);
        }
        private void selectItem(object sender, RoutedEventArgs e)
        {
            if (itemType == "Book")
            {
                main.showUpdateBookView(Convert.ToInt32(name.Split(" - ")[0]));
            }
            else if (itemType == "Stationary")
            {
                main.showUpdateStationaryView(Id);
            }
            else
            {
                main.showUpdateVoucherView(Id);
            }
        }


        private void check_(object sender, RoutedEventArgs e)
        {
            if (statusLbl.Content.Equals("Available"))
            {
                statusLbl.BorderBrush = Brushes.Green;
            }
        }


    }
}
