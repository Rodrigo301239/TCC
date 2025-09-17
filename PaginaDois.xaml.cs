 using Microsoft.Maui.Controls;

namespace TCC
{
    public class PaginaDois : ContentPage
    {
        public PaginaDois()
        {
            // Criando a interface via C#
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Children = {
                    new Label { Text = "Bem-vindo à Página Dois!" }
                }
            };
        }
    }
}
