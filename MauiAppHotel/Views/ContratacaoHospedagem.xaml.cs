using MauiAppHotel.Models;

namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    App PropriedadesApp;

    public ContratacaoHospedagem()
    {
        InitializeComponent();

        PropriedadesApp = (App)Application.Current!;

        // Carrega a lista de objetos Quarto no Picker
        pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;

        // Check-in: de hoje até 1 mês para frente
        dtpck_checkin.MinimumDate = DateTime.Today;
        dtpck_checkin.MaximumDate = DateTime.Today.AddMonths(1);
        dtpck_checkin.Date = DateTime.Today;

        // Check-out: a partir do dia seguinte ao check-in, até 6 meses
        dtpck_checkout.MinimumDate = DateTime.Today.AddDays(1);
        dtpck_checkout.MaximumDate = DateTime.Today.AddMonths(6);
        dtpck_checkout.Date = DateTime.Today.AddDays(1);
    }

    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = (DatePicker)sender;

        DateTime data_selecionada_checkin = Convert.ToDateTime(elemento.Date);

        dtpck_checkout.MinimumDate = data_selecionada_checkin.AddDays(1);
        dtpck_checkout.MaximumDate = data_selecionada_checkin.AddMonths(6);

        if (Convert.ToDateTime(dtpck_checkout.Date) <= data_selecionada_checkin)
            dtpck_checkout.Date = data_selecionada_checkin.AddDays(1);
    }

    private void pck_quarto_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (pck_quarto.SelectedItem is Quarto q)
        {
            lbl_previa.Text = $"{q.Descricao}: adulto {q.ValorDiariaAdulto:C} • criança {q.ValorDiariaCrianca:C} " +
                              $"por diária (até {q.Capacidade} hóspedes)";
        }
    }

    private async void Avancar_Clicked(object sender, EventArgs e)
    {
        try
        {
            // As validações ficam dentro da classe Hospedagem (set das propriedades)
            Hospedagem h = new Hospedagem
            {
                QuartoSelecionado = (Quarto)pck_quarto.SelectedItem,
                QntAdultos = Convert.ToInt32(stp_adultos.Value),
                QntCriancas = Convert.ToInt32(stp_criancas.Value),
                DataCheckIn = Convert.ToDateTime(dtpck_checkin.Date),
                DataCheckOut = Convert.ToDateTime(dtpck_checkout.Date),
            };

            h.ValidarCapacidade();

            await Navigation.PushAsync(new HospedagemContratada()
            {
                BindingContext = h
            });
        }
        catch (ArgumentException ex)
        {
            await DisplayAlert("Atenção", ex.Message, "OK");
        }
        catch (Exception ex)
        {
            await DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private async void Suites_Clicked(object sender, EventArgs e)
    {
        // Quando o usuário escolhe uma suíte na outra tela, ela já vem selecionada no Picker
        await Navigation.PushAsync(new Suites(quarto => pck_quarto.SelectedItem = quarto));
    }

    private async void Sobre_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Sobre());
    }
}
