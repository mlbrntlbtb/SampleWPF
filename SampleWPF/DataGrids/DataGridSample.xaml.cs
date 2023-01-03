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
using SampleWPF.Lists;

namespace SampleWPF.DataGrids
{
    /// <summary>
    /// Interaction logic for DataGridSample.xaml
    /// </summary>
    public partial class DataGridSample : Window
    {
        public DataGridSample()
        {
            InitializeComponent();
            List<PokemonAdv> Pokemons = new List<PokemonAdv>();
            Pokemons.Add(new PokemonAdv() { Name = "Moltres", Image = "/Resources/Moltres.jpg", Element = new Element() { Name = "Fire", Color = "Red", Icon = "/Resources/Fire.png" } });
            Pokemons.Add(new PokemonAdv() { Name = "Articuno", Image = "/Resources/Articuno.jpg", Element = new Element() { Name = "Ice", Color = "SkyBlue", Icon = "/Resources/Ice.png" } });
            Pokemons.Add(new PokemonAdv() { Name = "Zapdos", Image = "/Resources/Zapdos.jpg", Element = new Element() { Name = "Electric", Color = "Yellow", Icon = "/Resources/Electric.png" } });
            Pokemons.Add(new PokemonAdv() { Name = "Rayquaza", Image = "/Resources/Rayquaza.jpg", Element = new Element() { Name = "Dragon", Color = "DarkGreen", Icon = "/Resources/Dragon.png" } });
            Pokemons.Add(new PokemonAdv() { Name = "Pikachu", Image = "/Resources/Pikachu.jpg", Element = new Element() { Name = "Electric", Color = "Yellow", Icon = "/Resources/Electric.png" } });
            Pokemons.Add(new PokemonAdv() { Name = "Squirtle", Image = "/Resources/Squirtle.jpg", Element = new Element() { Name = "Water", Color = "Blue", Icon = "/Resources/Water.png" } });
            Pokemons.Add(new PokemonAdv() { Name = "Charmander", Image = "/Resources/Charmander.jpg", Element = new Element() { Name = "Fire", Color = "Red", Icon = "/Resources/Fire.png" } });
            Pokemons.Add(new PokemonAdv() { Name = "Bulbasaur", Image = "/Resources/Balbasaur.jpg", Element = new Element() { Name = "Plant", Color = "Green", Icon = "/Resources/Plant.png" } });

            dgSamp.ItemsSource = Pokemons;
        }
    }
}
