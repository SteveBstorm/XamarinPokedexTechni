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
    public partial class PokedexView : ContentPage
    {
        public PokedexView()
        {
            BindingContext = new PokedexViewModel();
            InitializeComponent();
        }
    }
}