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
	public partial class Page4 : ContentPage
	{
		public Page4 ()
		{
			InitializeComponent ();
            permissions.Source = ImageSource.FromFile("Group_7.png");
        }
        async void OnCreateAccount(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Settings());
        }
        async void OnLogin(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Settings());
        }
    }
}