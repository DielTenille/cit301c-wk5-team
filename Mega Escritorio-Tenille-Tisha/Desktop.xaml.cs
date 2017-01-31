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
    /// Interaction logic for Desktop.xaml
    /// </summary>
    public partial class Desktop : Page
    {
        public Desktop()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            // View Drawers.xaml  
            Drawers drawersPage = new Drawers();
            this.NavigationService.Navigate(drawersPage);
        }

        public static double calculateDimension()
        {
            Console.WriteLine("Please enter a desk top length in inches:");
            string lengthString = Console.ReadLine();
            double deskLength = double.Parse(lengthString);

            Console.WriteLine("Please enter a desk top width in inches:");
            string widthString = Console.ReadLine();
            double deskWidth = double.Parse(widthString);

            double deskDimensions = deskLength * deskWidth;
            Console.WriteLine("Total desk top area: " + deskDimensions);

            return deskDimensions;
        }
        public static double calculateDimensionPrice(double deskDimensions)
        {
            double dimensionPrice = 0;

            if (deskDimensions > 1000)
            {
                deskDimensions = deskDimensions - 1000;
                dimensionPrice = deskDimensions * 5;
            }

            return dimensionPrice;
        }
    }
}
