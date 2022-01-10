using PokedexDal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinPokedex.ViewModels;

namespace XamarinPokedex.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PokemonDetailView : ContentPage
    {
        public PokemonDetailView(Result result)
        {
            BindingContext = new PokemonDetailViewModel(result);
            InitializeComponent();
        }
    }
}