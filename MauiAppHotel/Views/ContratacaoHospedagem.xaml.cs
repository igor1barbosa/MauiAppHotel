using MauiAppHotel.Models;

namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    App PropriedadesApp;

    public ContratacaoHospedagem()
    {
        InitializeComponent();

        PropriedadesApp = (App)Application.Current!;

        pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;

        dtpck_checkin.MinimumDate = DateTime.Today;
        dtpck_checkin.MaximumDate = DateTime.Today.AddMonths(1);

        dtpck_checkout.MinimumDate = dtpck_checkin.Date.AddDays(1);
        dtpck_checkout.MaximumDate = dtpck_checkin.Date.AddMonths(6);
        dtpck_checkout.Date = dtpck_checkin.Date.AddDays(1);
    }

    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
        DateTime dataSelecionada = e.NewDate;

        dtpck_checkout.MinimumDate = dataSelecionada.AddDays(1);
        dtpck_checkout.MaximumDate = dataSelecionada.AddMonths(6);

        if (dtpck_checkout.Date <= dataSelecionada)
            dtpck_checkout.Date = dataSelecionada.AddDays(1);
    }

    private async void Avancar_Clicked(object sender, EventArgs e)
    {
        try
        {
            if (pck_quarto.SelectedItem is not Quarto quarto)
            {
                await DisplayAlert("Atenção", "Selecione uma suíte para continuar.", "OK");
                return;
            }

            Hospedagem h = new Hospedagem
            {
                QuartoSelecionado = quarto,
                QntAdultos = Convert.ToInt32(stp_adultos.Value),
                QntCriancas = Convert.ToInt32(stp_criancas.Value),
                DataCheckIn = dtpck_checkin.Date,
                DataCheckOut = dtpck_checkout.Date,
            };

            await Navigation.PushAsync(new HospedagemContratada()
            {
                BindingContext = h
            });
        }
        catch (Exception ex)
        {
            await DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private async void Sobre_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Sobre());
    }
}
