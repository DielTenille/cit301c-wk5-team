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
    /// Interaction logic for DeskMaterials.xaml
    /// </summary>
    public partial class DeskMaterials : Page
    {
        public double materialSelectionPrice;
        public int materialChosen;

        public DeskMaterials()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            calculateMaterialPrice();
            // View Desktop.xaml  
            Desktop desktopPage = new Desktop();
            this.NavigationService.Navigate(desktopPage);
        }
        private void Load_Click(object sender, RoutedEventArgs e)
        {
            if (oak.IsChecked == true)
            {
                materialChosen = 0;
            } else if (laminate.IsChecked == true)
            {
                materialChosen = 1;
            } else if (pine.IsChecked == true)
            {
                materialChosen = 2;
            } else
            {
                MessageBox.Show("Please select a desk material!");
            };
            
        }

        public void calculateMaterialPrice()
        {
            double[] materialTypePrice = new double[]
            {
                200, 100, 50
            };                 
           
            double materialSelectionPrice = materialTypePrice[materialChosen];

        }
    }
}
