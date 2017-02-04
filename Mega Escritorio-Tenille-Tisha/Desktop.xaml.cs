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
        public double deskDimensions { get; set; }
        public double dimensionPrice { get; set; }
        public int length { get; set; }
        public int widthSelected { get; set; }

        public Desktop()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            calculateDimension();
            // View Drawers.xaml  
            Drawers drawersPage = new Drawers();
            this.NavigationService.Navigate(drawersPage);
        }

        public void calculateDimension()
        {
            double deskDimensions = length * widthSelected;
            Console.WriteLine("Total desk top area: " + deskDimensions);

            DeskOrder desk = (DeskOrder)Application.Current.Properties["Desk"];
            desk.deskSize = deskDimensions;

            calculateDimensionPrice(deskDimensions);                      
        }

        public void calculateDimensionPrice(double deskDimension)
        {
            
            if (deskDimension > 1000)
            {
                deskDimensions = deskDimension - 1000;
                dimensionPrice = deskDimensions * 5;
                Console.WriteLine("Desk Dimension Price: " + dimensionPrice);

                DeskOrder desk = (DeskOrder)Application.Current.Properties["Desk"];
                desk.dimensionPrice = dimensionPrice;
            } else
            {
                dimensionPrice = 0;
                Console.WriteLine("Desk Dimension Price: " + dimensionPrice);

                DeskOrder desk = (DeskOrder)Application.Current.Properties["Desk"];
                desk.dimensionPrice = dimensionPrice;
            }
            

        }

        private void comboBox_Loaded1(object sender, RoutedEventArgs e)
        {
            // Drop down List.
            List<int> data = new List<int>();
            data.Add(24);
            data.Add(28);
            data.Add(32);
            data.Add(36);
            data.Add(40);
            data.Add(44);
            data.Add(48);
            data.Add(52);
            data.Add(56);
            data.Add(60);
            data.Add(64);
            data.Add(68);
            data.Add(72);

            // Get the ComboBox reference.
            var comboBox = sender as ComboBox;

            // Assign the ItemsSource to the List.
            comboBox.ItemsSource = data;

            // Makes the first item selected.
            comboBox.SelectedIndex = 0;
        }

        private void comboBox_SelectionChanged1(object sender, SelectionChangedEventArgs e)
        {
            // Get the ComboBox.
            var comboBox = sender as ComboBox;

            // Set SelectedItem as Window Title.
            length = int.Parse(comboBox.SelectedItem.ToString());
            this.Title = "Selected: " + length;

            DeskOrder desk = (DeskOrder)Application.Current.Properties["Desk"];
            desk.deskLength = length;
        }

        private void comboBox_Loaded2(object sender, RoutedEventArgs e)
        {
            // Drop down List.
            List<int> data = new List<int>();
            data.Add(24);
            data.Add(28);
            data.Add(32);
            data.Add(36);
            data.Add(40);
            data.Add(44);
            data.Add(48);           

            // Get the ComboBox reference.
            var comboBox = sender as ComboBox;

            // Assign the ItemsSource to the List.
            comboBox.ItemsSource = data;

            // Makes the first item selected.
            comboBox.SelectedIndex = 0;
        }

        private void comboBox_SelectionChanged2(object sender, SelectionChangedEventArgs e)
        {
            // Get the ComboBox.
            var comboBox = sender as ComboBox;

            // Set SelectedItem as Window Title.
            widthSelected = int.Parse(comboBox.SelectedItem.ToString());
            this.Title = "Selected: " + widthSelected;

            DeskOrder desk = (DeskOrder)Application.Current.Properties["Desk"];
            desk.deskwidth = widthSelected;
        }
    }
}
