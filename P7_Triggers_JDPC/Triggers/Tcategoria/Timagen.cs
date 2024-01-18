using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace P7_Triggers_JDPC.Triggers.Tcategoria
{
    public class Timagen : TriggerAction<Image>
    {
        public bool activation {  get; set; }
    protected override async void Invoke(Image sender)
        {
            if (activation==true) 
            {
                sender.BackgroundColor = Color.Red;
                //Rotación que tendrá, tiempo que tardará en milisegundos,
                // tipo de animación (efecto)
                await sender.RelRotateTo(360,5000,Easing.BounceOut);
            }
            if (activation==false)
            {
                //En esta parte restauramos los valores a un estado normal
                sender.BackgroundColor = new Image().BackgroundColor;
                sender.Rotation = new Image().Rotation;
            }
        }
    }
}
