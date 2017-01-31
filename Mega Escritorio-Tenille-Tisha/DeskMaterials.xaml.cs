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
        public DeskMaterials()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            // View Desktop.xaml  
            Desktop desktopPage = new Desktop();
            this.NavigationService.Navigate(desktopPage);
        }

        public static double calculateMaterialPrice()
        {
            const int MIN_NUM = 0;
            const int MAX_NUM = 2;

            double[] materialTypePrice = new double[]
            {
                200, 100, 50
            };

            string[] materialType = new string[]
            {
                "Oak", "Laminate", "Pine"
            };

            Console.WriteLine("Please choose a desk material by typing the associated number. \n 0 = " + materialType[0] + ", 1 = " + materialType[1] + ", 2 = " + materialType[2]);
            int materialChosen;
            do
            {
                string materialChosenString = Console.ReadLine();
                materialChosen = int.Parse(materialChosenString);
                if (materialChosen < MIN_NUM || materialChosen > MAX_NUM)
                {
                    Console.WriteLine("Please enter a number between 0 and 2.");
                }
            } while (materialChosen < MIN_NUM || materialChosen > MAX_NUM);

            double materialSelectionPrice = materialTypePrice[materialChosen];

            return materialSelectionPrice;

        }
    }
}
