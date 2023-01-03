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

namespace SampleWPF.Lists
{
    /// <summary>
    /// Interaction logic for ListViewAdvanced.xaml
    /// </summary>
    public partial class ListViewAdvanced : Window
    {
        public ListViewAdvanced()
        {
            InitializeComponent();
            List<Pokemon> list = new List<Pokemon>();
            list.Add(new Pokemon() { Name = "Pikachu", Element = "Lightning", Color="Yellow", Image = @"/Resources/Pikachu.jpg" });
            list.Add(new Pokemon() { Name = "Squirtle", Element = "Water", Color="Blue", Image = @"/Resources/Squirtle.jpg" });
            list.Add(new Pokemon() { Name = "Charmander", Element = "Fire", Color="Red", Image = @"/Resources/Charmander.jpg" });
            lvSamp.ItemsSource = list;
        }
    }
}
