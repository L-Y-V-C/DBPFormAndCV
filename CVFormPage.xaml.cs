using System;
using Xamarin.Forms;

namespace appCV
{
    public partial class CVFormPage : ContentPage
    {
        public CVFormPage()
        {
            InitializeComponent();
        }

        private async void OnSubmitClicked(object sender, EventArgs e)
        {
            string sname = name.Text;
            string semail = email.Text;
            string sphone = phone.Text;
            string saddress = address.Text;
            string slanguage = language.Text;
            string sexperience = experience.Text;
            string seducation = education.Text;

            string message = $"Nombre: {sname}\nCorreo: {semail}\nTeléfono: {sphone}\nDirección: {saddress}\nExperiencia: {sexperience}\nEducación: {seducation}";

            await DisplayAlert("Datos Enviados", message, "OK");

            name.Text = string.Empty;
            email.Text = string.Empty;
            phone.Text = string.Empty;
            address.Text = string.Empty;
            language.Text = string.Empty;
            experience.Text = string.Empty;
            education.Text = string.Empty;
        }
    }
}
