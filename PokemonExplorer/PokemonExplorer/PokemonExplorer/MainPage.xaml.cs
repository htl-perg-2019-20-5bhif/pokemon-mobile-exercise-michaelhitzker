using PokemonExplorer.Model;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace PokemonExplorer
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private List<Pokemon> PokemonsValue;
        private readonly PokemonManager manager;

        public List<Pokemon> Pokemons
        {
            get => PokemonsValue;
            set
            {
                PokemonsValue = value;
                OnPropertyChanged(nameof(Pokemons));
            }
        }

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;

            manager = new PokemonManager();
            Pokemons = manager.GetAllPokemons().GetAwaiter().GetResult().Results;
        }

    }
}
