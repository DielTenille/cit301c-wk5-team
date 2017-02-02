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
    /// Interaction logic for RushOrderOptions.xaml
    /// </summary>
    public partial class RushOrderOptions : Page
    {
        public RushOrderOptions()
        {
            InitializeComponent();
        }
        private void getQuote(object sender, RoutedEventArgs e)
        {
            // View OrderSummaryPage.xaml  
            OrderSummaryPage orderSummary = new OrderSummaryPage();
            this.NavigationService.Navigate(orderSummary);
        }

        /*
         * 
         * private void rushSelection_Click(object sender, RoutedEventArgs e)
        {
            if (radioButton.IsChecked == true)
            {
                rushChosen = 3;
            }
            else if (radioButton1.IsChecked == true)
            {
                rushChosen = 5;
            }
            else if (radioButton2.IsChecked == true)
            {
                rushChosen = 7;
            }
            else
            {
                MessageBox.Show("Please make a selection!");
            }

        }
        */

        private static int determineRushSize(double deskDimensions)
        {
            int[] rushSizeOptions = new int[]
            {
                1000, 1999, 2000
            };

            if (deskDimensions < rushSizeOptions[0])
            {
                return 1000;
            }
            else if (deskDimensions <= rushSizeOptions[1])
            {
                return 1999;
            }
            else
            {
                return 2000;
            }
        }

        /*
         * 
         * public static double calculateRushOrderPrice(double deskDimensions)
        {
            double rushOrderSelectionPrice = 0;
            double price;
            int rushChosen;
            int[] rushOptions = new int[]
            {
                3, 5, 7
            };

            string priceFile = @"C:\Users\t2alaska\cit301c\TenilleDiel_Mega-Escritorio-App\TenilleDiel_Mega-Escritorio-App\bin\Debug\price-table.txt";

            try
            {
                string[] rushOrderPrices = File.ReadAllLines(priceFile);

                double[][] rushOrderArray = new double[rushOrderPrices.Length][];
                for (int i = 0; i < rushOrderPrices.Length; i++)
                {
                    var columns = rushOrderPrices[i].Split(new char[] { ',' });
                    rushOrderArray[i] = new double[] {
                        Double.Parse(columns[0]),Double.Parse(columns[1]),Double.Parse(columns[2]),
                    };
                }

                //Ask the user if they want rush order shipping
                Console.WriteLine("Would you like Rush Order Shipping?");
                string feelingRushed = Console.ReadLine();
                if (feelingRushed == "n")
                {
                    return rushOrderSelectionPrice;
                }
                else
                {
                    //Ask the user if they want 3, 5, or 7 day rush shipping
                    Console.WriteLine("How fast do you want your order shipped? \n 0 = " + rushOptions[0] + "-Day" + ", 1 = " + rushOptions[1] + "-Day" + ", 2 = " + rushOptions[2] + "-Day");
                    do
                    {
                        string rushChosenString = Console.ReadLine();
                        rushChosen = int.Parse(rushChosenString);
                        if (rushChosen < 0 || rushChosen > 2)
                        {
                            Console.WriteLine("Please enter a number between 0 and 2.");
                        }
                    } while (rushChosen < 0 || rushChosen > 2);
                }
                //Decide what the price should be
                double rushSelected = rushOptions[rushChosen];
                double deskSize = determineRushSize(deskDimensions);
                price = rushOrderArray.Where(i => i[0] == rushSelected).Where(i => i[1] == deskSize).First()[2];
                Console.WriteLine("The rush order price will be: $" + price);
                return price;
            }
            catch (Exception e)
            {
                Console.WriteLine("There was a problem with the file.");
            }
            return price = 1;
        }
         */

    }
}
