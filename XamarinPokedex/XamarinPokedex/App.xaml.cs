using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinPokedex
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new XamarinPokedex.Views.PokedexView();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
