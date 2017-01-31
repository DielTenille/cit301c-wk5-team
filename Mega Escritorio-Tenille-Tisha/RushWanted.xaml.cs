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

namespace Mega_Escritorio_Tenille_Tisha
{
    /// <summary>
    /// Interaction logic for RushWanted.xaml
    /// </summary>
    public partial class RushWanted : Page
    {
        public RushWanted()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            //if(radio_button = "Yes") {
            // View RushOrderOptions.xaml  
            RushOrderOptions rushOrderPage = new RushOrderOptions();
            this.NavigationService.Navigate(rushOrderPage);
            //} else {
            // View OrderSummaryPage.xaml  
            //OrderSummaryPage orderSummary = new OrderSummaryPage();
            //this.NavigationService.Navigate(orderSummary);
            //}
        }
    }
}
