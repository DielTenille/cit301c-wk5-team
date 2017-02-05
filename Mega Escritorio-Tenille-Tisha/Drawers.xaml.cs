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


enum DrawerCount
{
    zero,
    one,
    two,
    three,
    four,
    five,
    six,
    seven
}
namespace Mega_Escritorio_Tenille_Tisha
{
    /// <summary>
    /// Interaction logic for Drawers.xaml
    /// </summary>
    public partial class Drawers : Page
    {
        int numDrawers;
        int drawerSelectionPrice;

        public Drawers()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            calculateDrawerPrice();
            // View RushWanted.xaml  
            RushWanted rushWantedPage = new RushWanted();
            this.NavigationService.Navigate(rushWantedPage);
        }

        public void calculateDrawerPrice()
        {
            int drawerPrice = 50;
            drawerSelectionPrice = drawerPrice * numDrawers;
            Console.WriteLine("Drawer Price: " + drawerSelectionPrice);

            DeskOrder desk = (DeskOrder)Application.Current.Properties["Desk"];
            desk.drawerPrice = drawerSelectionPrice;
            desk.numDrawers = numDrawers;

        }

        private void drawerSelection_Click(object sender, RoutedEventArgs e)
        {
            if(radioButton.IsChecked == true)
            {
                numDrawers = (int)DrawerCount.zero;
            }
            else if (radioButton1.IsChecked == true)
            {
                numDrawers = (int)DrawerCount.one;
            }
            else if (radioButton2.IsChecked == true)
            {
                numDrawers = (int)DrawerCount.two;
            }
            else if (radioButton3.IsChecked == true)
            {
                numDrawers = (int)DrawerCount.three;
            }
            else if (radioButton4.IsChecked == true)
            {
                numDrawers = (int)DrawerCount.four;
            }
            else if (radioButton5.IsChecked == true)
            {
                numDrawers = (int)DrawerCount.five;
            }
            else if (radioButton6.IsChecked == true)
            {
                numDrawers = (int)DrawerCount.six;
            }
            else if (radioButton7.IsChecked == true)
            {
                numDrawers = (int)DrawerCount.seven;
            } else
            {
                MessageBox.Show("Please make a selection!");
            }

        }

        private void radioButton7_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void label_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
