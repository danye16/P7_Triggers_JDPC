using P7_Triggers_JDPC.VistaModelo;
using P7_Triggers_JDPC.Vistas;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace P7_Triggers_JDPC
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PaginaCategoria();
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
