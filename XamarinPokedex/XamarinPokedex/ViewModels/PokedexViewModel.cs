using PokedexDal.Models;
using PokedexDal.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using XamarinPokedex.Tools;
using XamarinPokedex.Views;

namespace XamarinPokedex.ViewModels
{
    public class PokedexViewModel : ViewModelBase
    {
        private PokedexService _service;

        

        private string _next;

        public string Next
        {
            get { return _next; }
            set { SetValue(ref _next, value); }
        }

        private string _previous;

        public string Previous
        {
            get { return _previous; }
            set { SetValue(ref _previous, value); }
        }

        private ObservableCollection<Result> _results;
        public ObservableCollection<Result> Results { 
            get { return _results; }
            set { SetValue(ref _results, value); } 
        }

        private Result _selectedPokemon;

        public Result SelectedPokemon
        {
            get { return _selectedPokemon; }
            set { 
                if(_selectedPokemon != value)
                {
                    _selectedPokemon = value;
                    App.Current.MainPage.Navigation.PushModalAsync(new PokemonDetailView(_selectedPokemon));
                }
            }
        }

        private Command _nextCommand;

        public Command NextCommand
        {
            get { return _nextCommand = _nextCommand ?? new Command(NextMethod); }
        }

        public void NextMethod()
        {
            LoadItems(Next);
        }

        private Command _previousCommand;

        public Command PreviousCommand
        {
            get { return _previousCommand = _previousCommand ?? new Command(PreviousMethod); }
        }

        public void PreviousMethod()
        {
            LoadItems(Previous);
        }


        public PokedexViewModel()
        {
            _service = new PokedexService();
            LoadItems("https://pokeapi.co/api/v2/pokemon");
        }

        public void LoadItems(string url)
        {
            Pokedex myPokedex = _service.Get<Pokedex>(url);

            Previous = myPokedex.Previous;
            Next = myPokedex.Next;

            Results = new ObservableCollection<Result>();

            foreach (Result item in myPokedex.Results)
            {
                Results.Add(item);
            }
        }



    }
}
