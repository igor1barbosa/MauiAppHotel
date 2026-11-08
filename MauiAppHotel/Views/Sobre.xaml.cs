using MauiAppHotel.Models;

namespace MauiAppHotel.Views;

public partial class Sobre : ContentPage
{
    public Sobre()
    {
        InitializeComponent();

        // Todas as informações da tela vêm do objeto InfoApp via BindingContext
        BindingContext = new InfoApp();
    }

    private async void Voltar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
