using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HospitalSanJose
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
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
            Navigation.PushAsync(new SegundaMain2());
        }
      
    }
}
