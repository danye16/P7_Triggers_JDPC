using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using P7_Triggers_JDPC.Modelo;
using P7_Triggers_JDPC.Datos;

namespace P7_Triggers_JDPC.VistaModelo
{
    public class VMcatetgoria : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        ObservableCollection<Mcategorias> _listtaCategorias;
        #endregion
        #region CONSTRUCTOR
        public VMcatetgoria(INavigation navigation)
        {
            Navigation = navigation;
            MostrarCategorias();

        }
        #endregion
        #region OBJETOS
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        public ObservableCollection<Mcategorias>ListaCategorias
        {
            get {return _listtaCategorias; }
            set { SetValue(ref _listtaCategorias, value); }
        }
        #endregion
        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {

        }
        public void procesoSimple()
        {

        }
        public void MostrarCategorias()
        {
            //Al hacer esto estamos jalando toda la data
            ListaCategorias = new ObservableCollection<Mcategorias>(Datos.Dcategorias.MostrarCategorias());
        }

        #endregion
        #region COMANDOS
        public ICommand ProcesoAsyncomand => new Command(async () => await ProcesoAsyncrono());
        public ICommand ProcesoSimpcomand => new Command(MostrarCategorias);
        #endregion
    }
}
