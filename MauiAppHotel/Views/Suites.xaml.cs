using MauiAppHotel.Models;

namespace MauiAppHotel.Views;

public partial class Suites : ContentPage
{
    // Ação executada quando o usuário escolhe uma suíte
    private readonly Action<Quarto> _aoEscolher;

    public Suites(Action<Quarto> aoEscolher)
    {
        InitializeComponent();

        _aoEscolher = aoEscolher;

        App propriedadesApp = (App)Application.Current!;
        lst_suites.ItemsSource = propriedadesApp.lista_quartos;
    }

    private async void lst_suites_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is Quarto quarto)
        {
            _aoEscolher(quarto);
            await Navigation.PopAsync();
        }
    }
}
