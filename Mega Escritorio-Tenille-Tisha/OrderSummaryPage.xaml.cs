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
    /// Interaction logic for OrderSummaryPage.xaml
    /// </summary>
    public partial class OrderSummaryPage : Page
    {
        public OrderSummaryPage()
        {
            InitializeComponent();
        }

        private void startOver(object sender, RoutedEventArgs e)
        {
            // View Welcome Page  
            MegaEscritorioHome homePage = new MegaEscritorioHome();
            this.NavigationService.Navigate(homePage);
        }

        private void completeOrder(object sender, RoutedEventArgs e)
        {
            // View ThankYouPage.xaml  
            ThankYouPage thankYouPage = new ThankYouPage();
            this.NavigationService.Navigate(thankYouPage);
        }

        public static void createPriceQuote(double materialPrice, double drawerPrice, double dimensionPrice, double rushOrderPrice)
        {
            Random rand = new Random();
            const double BASE_DESK_PRICE = 200;
            int orderID = rand.Next();

            Console.WriteLine("\n Order ID: #" + orderID);
            Console.WriteLine(" Base Desk Price: $" + BASE_DESK_PRICE);
            Console.WriteLine(" Desk Material Price: $" + materialPrice);
            Console.WriteLine(" Desk Drawer Price: $" + drawerPrice);
            Console.WriteLine(" Extra Large Surface Area Price: $" + dimensionPrice);
            Console.WriteLine(" Rush Order Price: $" + rushOrderPrice);

            double totalPrice = BASE_DESK_PRICE + materialPrice + drawerPrice + dimensionPrice + rushOrderPrice;
            Console.WriteLine("\n *****  Total Custom Desk Price: $" + totalPrice + "  *****");

            savePriceQuoteToFile(orderID, BASE_DESK_PRICE, materialPrice, drawerPrice, dimensionPrice, rushOrderPrice, totalPrice);


        }
        public static void savePriceQuoteToFile(double orderID, double baseDeskPrice, double materialPrice, double drawerPrice, double dimensionPrice, double rushOrderPrice, double totalPrice)
        {
            //string json = JsonConvert.SerializeObject(new
            //{
            //    OrderID = orderID,
            //    BaseDesk = baseDeskPrice,
            //    Material = materialPrice,
            //    Drawers = drawerPrice,
            //    Dimension = dimensionPrice,
            //    RushOrder = rushOrderPrice,
            //    TotalPrice = totalPrice
            //});

            ////write string to file
            //System.IO.File.AppendAllText(@"C:\Users\t2alaska\cit301c\TenilleDiel_Mega-Escritorio-App\orders.txt", json);
        }
    }
}
