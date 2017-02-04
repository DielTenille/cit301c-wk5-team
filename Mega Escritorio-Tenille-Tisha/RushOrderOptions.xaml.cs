using System;
using System.Collections.Generic;
using System.IO;
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
        int rushChosen;
        double price;
        
        public RushOrderOptions()
        {
            InitializeComponent();
        }
        private void getQuote(object sender, RoutedEventArgs e)
        {
            DeskOrder desk = (DeskOrder)Application.Current.Properties["Desk"];
            double dimensions = desk.deskSize;

            calculateRushOrderPrice(dimensions);
            // View OrderSummaryPage.xaml  
            OrderSummaryPage orderSummary = new OrderSummaryPage();
            this.NavigationService.Navigate(orderSummary);
        }

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

        private void radioButton_Click(object sender, RoutedEventArgs e)
        {
            if (radioButton3.IsChecked == true)
            {
                rushChosen = 0;
            }
            else if (radioButton5.IsChecked == true)
            {
                rushChosen = 1;
            }
            else if (radioButton7.IsChecked == true)
            {
                rushChosen = 2;
            } else
            {
                MessageBox.Show("Please make a selection!");
            }
        }


        public void calculateRushOrderPrice(double deskDimensions)
        {
            int[] rushOptions = new int[]
            {
                3, 5, 7
            };

            //string priceFile = "price-table.txt";
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

                //Decide what the price should be
                double rushSelected = rushOptions[rushChosen];
                double deskSize = determineRushSize(deskDimensions);
                price = rushOrderArray.Where(i => i[0] == rushSelected).Where(i => i[1] == deskSize).First()[2];

                DeskOrder desk = (DeskOrder)Application.Current.Properties["Desk"];
                desk.rushOrderPrice = price;

            }
            catch (Exception e)
            {
                Console.WriteLine("There was a problem with the file.");
            }
        }
    }
}
