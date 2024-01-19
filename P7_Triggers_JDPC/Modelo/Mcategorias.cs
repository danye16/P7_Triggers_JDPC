using P7_Triggers_JDPC.VistaModelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace P7_Triggers_JDPC.Modelo
{
    public class Mcategorias : BaseViewModel
    {
        public string descripcion { get; set; }
        public int numeroItem { get; set; }
        public string imagen { get; set; }

        public string _backgroundColor;
        public string _textColor;
        public bool _selected;

        public string backgroundColor
        {
            get { return _backgroundColor; }
            set { SetProperty(ref _backgroundColor, value); }
        }

        public string textColor
        {
            get { return _textColor; }
            set { SetProperty(ref _textColor, value); }
        }

        public bool selected
        {
            get { return _selected; }
            set { SetProperty(ref _selected, value); }
        }
    }
}
