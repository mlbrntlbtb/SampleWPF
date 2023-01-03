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
    /// Interaction logic for ContextMenuSample.xaml
    /// </summary>
    public partial class ContextMenuSample : Window
    {
        public ContextMenuSample()
        {
            InitializeComponent();
        }

        private void ShowContextMenu_Click(object sender, RoutedEventArgs e)
        {
            ContextMenu menu = ((ContextMenu)FindResource("ctxMenu"));
            //menu.PlacementTarget = sender as Button;
            menu.IsOpen = true;
        }
    }
}
