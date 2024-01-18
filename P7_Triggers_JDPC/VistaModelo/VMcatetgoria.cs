using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using P7_Triggers_JDPC.Modelo;
using P7_Triggers_JDPC.Datos;
using System.Linq;
using Xamarin.Forms.Internals;

namespace P7_Triggers_JDPC.VistaModelo
{
    public class VMcatetgoria : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        bool _activadorAnimacionImg;
        string _imagen;
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
        public string Imagen
        {
            get { return _imagen; }
            set { SetValue(ref _imagen, value); }
        }
        public bool ActivadorAnimacionImg
        {
            get { return _activadorAnimacionImg; }
            set { SetValue(ref _activadorAnimacionImg, value); } 
        }
        #endregion
        #region PROCESOS
        public void Seleccionar(Mcategorias modelo) 
        {
            //Con el index identificamos a qué imágen le hemos dado click
            var index = ListaCategorias
                .ToList()
                .FindIndex(p => p.descripcion == modelo.descripcion);

            Imagen = modelo.imagen;
            if (index>-1) 
            {
                Deseleccionar();
                ActivadorAnimacionImg= true;
                ListaCategorias[index].selected = true;
                ListaCategorias[index].textColor = "#FFFFFF";
                ListaCategorias[index].backgroundColor = "#FF506B";
            }
        }

        public void Deseleccionar()
        {
            ListaCategorias.ForEach((item) =>
             {
                 ActivadorAnimacionImg = false;
                 item.selected = false;
                 item.textColor = "#000000";
                 item.backgroundColor = "#EAEDF6";

             });
        }

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
        public ICommand ProcesoSimpCommand => new Command(MostrarCategorias);
        public ICommand ProcesoSimpleSeleccionar => new Command<Mcategorias>((p) => Seleccionar(p));
        #endregion
    }
}
