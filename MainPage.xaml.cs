using System;
using Xamarin.Forms;

namespace appCV
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnNavigateToCVFormPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CVFormPage());
        }
    }
}
