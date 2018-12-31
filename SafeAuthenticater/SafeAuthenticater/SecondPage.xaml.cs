using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SafeAuthenticater
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondPage : ContentPage
	{
		public SecondPage()
		{
			InitializeComponent();
            myImage1.Source = ImageSource.FromFile("Group_5.png");
        }

        async void OnContinue(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page3());
        }
        async void OnSkip(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Settings());
        }
    }
}