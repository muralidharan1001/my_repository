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
	public partial class Page5 : ContentPage
	{
		public Page5 ()
		{
			InitializeComponent ();
            grantpermissionsimg.Source = ImageSource.FromFile("Group_8.png");

        }
        async void OnContinue(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page4());
        }
        async void OnSkip(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Settings()); 
        }
    }
}