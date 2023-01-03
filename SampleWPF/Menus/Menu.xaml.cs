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
using System.Windows.Shapes;

namespace SampleWPF.Menus
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void NewMenu_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("New Menu");
        }

        private void OpenMenu_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Open Menu");
        }

        private void SaveMenu_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Save Menu");
        }

        private void ExitMenu_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Goodbye");
            System.Windows.Application.Current.Shutdown();
        }
    }
}
