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
    /// Interaction logic for MegaEscritorioHome.xaml
    /// </summary>
    public partial class MegaEscritorioHome : Page
    {
        public MegaEscritorioHome()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Get started button clicked.");
            // View DeskMaterial.xaml  
            DeskMaterials deskMaterialsPage = new DeskMaterials();
            this.NavigationService.Navigate(deskMaterialsPage);
        }
    }
}
