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
    public partial class QuintaMain5 : ContentPage
    {
        public QuintaMain5()
        {
            InitializeComponent();
        }


        async void OnCardiologiaSwitchToggled(object sender, ToggledEventArgs args)
        {
            await DisplayAlert("Cardiología", "el valor es: " + switchCardiologia.IsToggled, "Ok");
            //if (args.Value)
            //{
            //    label.FontAttributes |= FontAttributes.Italic;
            //}
            //else
            //{
            //    label.FontAttributes &= ~FontAttributes.Italic;
            //}
        }

        async void OnNeurocirugiaSwitchToggled(object sender, ToggledEventArgs args)
        {
            await DisplayAlert("Neurocirugia", "el valor es: " + switchCardiologia.IsToggled, "Ok");
            //    if (args.Value)
            //    {
            //        label.FontAttributes |= FontAttributes.Italic;
            //    }
            //    else
            //    {
            //        label.FontAttributes &= ~FontAttributes.Italic;
            //    }
        }

       async void OnCirugiaSwitchToggled(object sender, ToggledEventArgs args)
       {
            await DisplayAlert("Cirugia", "el valor es: " + switchCardiologia.IsToggled, "Ok");
            //    if (args.Value)
            //    {
            //        label.FontAttributes |= FontAttributes.Italic;
            //    }
            //    else
            //    {
            //        label.FontAttributes &= ~FontAttributes.Italic;
            //    }

       }

       async void OnRadiologiaSwitchToggled(object sender, ToggledEventArgs args)
       {
            await DisplayAlert("Radiologia", "el valor es: " + switchCardiologia.IsToggled, "Ok");
            //    if (args.Value)
            //    {
            //        label.FontAttributes |= FontAttributes.Italic;
            //    }
            //    else
            //    {
            //        label.FontAttributes &= ~FontAttributes.Italic;
            //    }
       }
    }
}