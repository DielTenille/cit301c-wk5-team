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
    /// Interaction logic for Drawers.xaml
    /// </summary>
    public partial class Drawers : Page
    {
        public Drawers()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            // View RushWanted.xaml  
            RushWanted rushWantedPage = new RushWanted();
            this.NavigationService.Navigate(rushWantedPage);
        }

        public static int calculateDrawerPrice()
        {
            const int MIN_DRAWERS = 0;
            const int MAX_DRAWERS = 7;
            int numDrawers;

            Console.WriteLine("Please enter the number of drawers you want your desk to have.");
            do
            {
                string numDrawerString = Console.ReadLine();
                numDrawers = int.Parse(numDrawerString);
                if (numDrawers < MIN_DRAWERS || numDrawers > MAX_DRAWERS)
                {
                    Console.WriteLine("Please enter a number between 0 and 7.");
                }
            } while (numDrawers < MIN_DRAWERS || numDrawers > MAX_DRAWERS);

            int drawerPrice = 50;
            int drawerSelectionPrice = drawerPrice * numDrawers;

            return drawerSelectionPrice;
        }
    }
}
