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
using WPF_CoffeeShop.Items;

namespace WPF_CoffeeShop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Thickness Thick = new Thickness(0, 0, 0, 0);
        public Thickness Cthick = new Thickness(0, 0, 0, 0);

        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            frame_list.Content = new PG_Plates()
            {
                
            };
        }

        private void B_CO_Click(object sender, RoutedEventArgs e)
        {
            
        }

    }
}
