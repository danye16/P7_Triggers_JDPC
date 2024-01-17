using P7_Triggers_JDPC.Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace P7_Triggers_JDPC.Datos
{
    public class Dcategorias
    {
        public static ObservableCollection<Mcategorias> MostrarCategorias()
        {
            return new ObservableCollection<Mcategorias>() {
            new Mcategorias()
            {
                descripcion ="Cena",
                numeroItem=4512,
                imagen="https://i.ibb.co/NySC96b/cena.png",
                backgroundColor="#EAEDF6",
                textColor="#000000"
            },
             new Mcategorias()
            {
                descripcion ="Hotel",
                numeroItem=4512,
                imagen="https://i.ibb.co/NySC96b/cena.png",
                backgroundColor="#EAEDF6",
                textColor="#000000"
            },
               new Mcategorias()
            {
                descripcion ="Fiesta",
                numeroItem=4512,
                imagen="https://i.ibb.co/yhyCMj0/fiestas-patrias.png",
                backgroundColor="#EAEDF6",
                textColor="#000000"
            },
                 new Mcategorias()
            {
                descripcion ="Flores",
                numeroItem=4512,
                imagen="https://i.ibb.co/s62Mzqx/flores.png",
                backgroundColor="#EAEDF6",
                textColor="#000000"
            },
            };
        }
    }
}
