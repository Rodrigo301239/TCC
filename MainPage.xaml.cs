using Microsoft.Maui.Controls;

namespace TCC
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnClickEmpresa(object sender, EventArgs e)
        {                        

            await Navigation.PushAsync(new PaginaDois());
        }
        private async void OnClickCandidato(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new PaginaTres());
        }
    }
}
