using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SafeAuthenticater
{

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            myImage.Source = ImageSource.FromFile("safe.png");
        }

        async void OnLogin(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Settings());
        }
        async void OnGetStarted(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page5());
        }
    }
}
