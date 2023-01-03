using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for TreeViewDataBinding.xaml
    /// </summary>
    public partial class TreeViewDataBinding : Window
    {
        public TreeViewDataBinding()
        {
            InitializeComponent();

            List<Rarity> rarities = new List<Rarity>();
            Rarity rarity1 = new Rarity() { Name = "Legendary"};
            rarity1.Pokemons.Add(new PokemonAdv() { Name = "Moltres", Image = "/Resources/Moltres.jpg", Element = new Element() { Name="Fire", Color="Red", Icon="/Resources/Fire.png" }});
            rarity1.Pokemons.Add(new PokemonAdv() { Name = "Articuno", Image = "/Resources/Articuno.jpg", Element = new Element() { Name = "Ice", Color = "SkyBlue", Icon = "/Resources/Ice.png" }});
            rarity1.Pokemons.Add(new PokemonAdv() { Name = "Zapdos", Image = "/Resources/Zapdos.jpg", Element = new Element() { Name = "Electric", Color = "Yellow", Icon = "/Resources/Electric.png" }});
            rarity1.Pokemons.Add(new PokemonAdv() { Name = "Rayquaza", Image = "/Resources/Rayquaza.jpg", Element = new Element() { Name = "Dragon", Color = "DarkGreen", Icon = "/Resources/Dragon.png" } });

            Rarity rarity2 = new Rarity() { Name = "Common" };
            rarity2.Pokemons.Add(new PokemonAdv() { Name = "Pikachu", Image = "/Resources/Pikachu.jpg", Element = new Element() { Name = "Electric", Color = "Yellow", Icon = "/Resources/Electric.png" } });
            rarity2.Pokemons.Add(new PokemonAdv() { Name = "Squirtle", Image = "/Resources/Squirtle.jpg", Element = new Element() { Name = "Water", Color = "Blue", Icon = "/Resources/Water.png" }});
            rarity2.Pokemons.Add(new PokemonAdv() { Name = "Charmander", Image = "/Resources/Charmander.jpg", Element = new Element() { Name = "Fire", Color = "Red", Icon = "/Resources/Fire.png" }});
            rarity2.Pokemons.Add(new PokemonAdv() { Name = "Bulbasaur", Image = "/Resources/Balbasaur.jpg", Element = new Element() { Name = "Plant", Color = "Green", Icon = "/Resources/Plant.png" }});

            rarities.Add(rarity1);
            rarities.Add(rarity2);

            tvSamp.ItemsSource = rarities;
        }

    }
    public class Rarity
    {
        public Rarity()
        {
            this.Pokemons = new ObservableCollection<PokemonAdv>();
        }
        public string Name { get; set; }
        public ObservableCollection<PokemonAdv> Pokemons { get; set; }
    }
}
