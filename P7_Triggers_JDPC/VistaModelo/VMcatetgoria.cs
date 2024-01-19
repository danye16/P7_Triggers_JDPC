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
    public class VMcategoria : BaseViewModel
    {
        #region VARIABLES
        string _Mensaje;
        ObservableCollection<Mcategorias> _listaCategorias;
        bool _activadorAnimacionImg;
        string _imagen;
        #endregion
        #region CONSTRUCTOR
        public VMcategoria(INavigation navigation)
        {
            Navigation = navigation;
            MostrarCategorias();
        }
        #endregion
        #region OBJETOS
        public string Imagen
        {
            get { return _imagen; }
            set { SetValue(ref _imagen, value); }
        }
        public string Mensaje
        {
            get { return _Mensaje; }
            set { SetValue(ref _Mensaje, value); }
        }
        public ObservableCollection<Mcategorias> ListaCategorias
        {
            get { return _listaCategorias; }
            set { SetValue(ref _listaCategorias, value); }
        }
        public bool ActivadorAnimacionImg
        {
            get { return _activadorAnimacionImg; }
            set { SetValue(ref _activadorAnimacionImg, value); }
        }
        #endregion
        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {

        }

        public void Seleccionar(Mcategorias modelo)
        {
            var index = ListaCategorias
                .ToList()
                .FindIndex(p => p.descripcion == modelo.descripcion);
            Imagen = modelo.imagen;
            if (index > -1)
            {
                Deseleccionar();
                ActivadorAnimacionImg = true;
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
        public void MostrarCategorias()
        {
            ListaCategorias = new ObservableCollection<Mcategorias>(Datos.Dcategorias.MostrarCategorias());
        }
        #endregion
        #region COMANDOS
        public ICommand ProcesoAsynCommand => new Command(async () => await ProcesoAsyncrono());
        public ICommand ProcesoSimpCommand => new Command(MostrarCategorias);
        public ICommand ProcesoSimpleSeleccionar => new Command<Mcategorias>((p) => Seleccionar(p));
        #endregion
    }
}