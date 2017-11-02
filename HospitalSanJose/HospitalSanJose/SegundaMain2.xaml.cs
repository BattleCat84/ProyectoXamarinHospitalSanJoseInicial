using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HospitalSanJose
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SegundaMain2 : ContentPage
    {
        public SegundaMain2()
        {
            InitializeComponent();

            Inicializar();
        }
       
        private void Inicializar()
        {
            imageLogoHospitalSanJose.Source= ImageSource.FromResource("HospitalSanJose.img.logohospitalsanjose.png");
            IrAOtraPagina.Clicked += OnButtonIrAOtraPagina;
            
        }

        private void OnButtonIrAOtraPagina(object sender, EventArgs e)
        {
            /**
             * 
             * Como pasar el dato a la otra actividad 
             * 
             **/

            Navigation.PushModalAsync(new TerceraMain32());

        }          
    }
}