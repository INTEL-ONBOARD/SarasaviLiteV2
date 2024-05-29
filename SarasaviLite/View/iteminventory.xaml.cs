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
using System.Windows.Shapes;

namespace SarasaviLite.View
{
    /// <summary>
    /// Interaction logic for item.xaml
    /// </summary>
    public partial class ItemInventory : Window
    {
        public ItemInventory()
        {
            InitializeComponent();
            this.DataContext = this;
        }


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

        }

        private void select_click(object sender, RoutedEventArgs e)
        {

        }
    }
}
