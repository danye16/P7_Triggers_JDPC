using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace P7_Triggers_JDPC.Triggers.Tcategoria
{
    public class Timagen : TriggerAction<Image>

    {
        public bool activacion { get; set; }
        protected override async void Invoke(Image sender)
        {
            if (activacion == true)
            {
                sender.BackgroundColor = Color.Red;
                await sender.RelRotateTo(360, 5000, Easing.BounceOut);
            }
            if (activacion == false)
            {
                sender.BackgroundColor = new Image().BackgroundColor;
                sender.Rotation = new Image().Rotation;
            }
        }

    }
}
