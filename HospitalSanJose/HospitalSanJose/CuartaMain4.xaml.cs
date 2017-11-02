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
	public partial class CuartaMain4 : ContentPage
	{
		public CuartaMain4 ()
		{
			InitializeComponent ();

            Inicializar();
		}

        private void Inicializar()
        {
            imageLogoHospitalSanJose.Source = ImageSource.FromResource("HospitalSanJose.img.logohospitalsanjose.png");
            imageLogoHospitalSanJose.Source = ImageSource.FromResource("HospitalSanJose.img.quienestumedico.png");
            IrAOtraPagina.Clicked += OnButtonIrAOtraPagina;
        }

        private void OnButtonIrAOtraPagina(object sender, EventArgs e)
        {
            Navigation.PushAsync(new QuintaMain5());
        }
    }
}