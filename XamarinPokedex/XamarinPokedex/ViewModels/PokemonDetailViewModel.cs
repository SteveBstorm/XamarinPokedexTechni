using PokedexDal.Models;
using PokedexDal.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamarinPokedex.Tools;

namespace XamarinPokedex.ViewModels
{
    public class PokemonDetailViewModel : ViewModelBase
    {
        private PokedexService _service;

        private Pokemon myPokemon;

        public Pokemon MyPokemon
        {
            get { return myPokemon; }
            set { SetValue(ref myPokemon, value); }
        }


        public PokemonDetailViewModel(Result result)
        {
            _service = new PokedexService();

            myPokemon = _service.Get<Pokemon>(result.Url);
        }

        private Command _closeCommand;

        public Command CloseCommand
        {
            get { return _closeCommand = _closeCommand ?? new Command(CloseMethod); }
            
        }

        public void CloseMethod()
        {
            App.Current.MainPage.Navigation.PopModalAsync();
        }

    }
}
