using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for ListViewGrouping.xaml
    /// </summary>
    public partial class ListViewGrouping : Window
    {
        public ListViewGrouping()
        {
            InitializeComponent();

            List<Pokemon> list = new List<Pokemon>();
            list.Add(new Pokemon() { Name = "Pikachu", Element = "Lightning", Color = "Yellow", Image = @"/Resources/Pikachu.jpg" });
            list.Add(new Pokemon() { Name = "Squirtle", Element = "Water", Color = "Blue", Image = @"/Resources/Squirtle.jpg" });
            list.Add(new Pokemon() { Name = "Charmander", Element = "Fire", Color = "Red", Image = @"/Resources/Charmander.jpg" });
            list.Add(new Pokemon() { Name = "Balbasaur", Element = "Plant", Color = "Green", Image = @"/Resources/Balbasaur.jpg" });
            lvSamp.ItemsSource = list;

            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lvSamp.ItemsSource);
            //view.SortDescriptions.Add(new SortDescription("Name", ListSortDirection.Ascending));
            PropertyGroupDescription groupDescription = new PropertyGroupDescription("Element");
            view.GroupDescriptions.Add(groupDescription);
        }
    }
}
