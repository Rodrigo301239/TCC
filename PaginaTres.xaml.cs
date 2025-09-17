using Microsoft.Maui.Controls;

namespace TCC
{
    public class PaginaTres : ContentPage
    {
        public PaginaTres()
        {
            // Criando a interface via C#
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Children = {
                    new Label { Text = "Bem-vindo à Página Tres!" }
                }
            };
        }
    }
}
