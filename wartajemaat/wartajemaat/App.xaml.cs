using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace wartajemaat
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavBar();
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
