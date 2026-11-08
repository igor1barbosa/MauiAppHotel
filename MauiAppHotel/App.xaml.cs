using System.Globalization;
using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto { Descricao = "Suíte Standard", ValorDiariaAdulto = 120, ValorDiariaCrianca = 60 },
            new Quarto { Descricao = "Suíte Vista Mar", ValorDiariaAdulto = 180, ValorDiariaCrianca = 90 },
            new Quarto { Descricao = "Suíte Família", ValorDiariaAdulto = 150, ValorDiariaCrianca = 70 },
            new Quarto { Descricao = "Suíte Presidencial", ValorDiariaAdulto = 320, ValorDiariaCrianca = 160 },
        };

        public App()
        {
            InitializeComponent();

            // Datas e moeda no padrão brasileiro
            CultureInfo cultura = new CultureInfo("pt-BR");
            CultureInfo.DefaultThreadCurrentCulture = cultura;
            CultureInfo.DefaultThreadCurrentUICulture = cultura;

        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = new Window(new NavigationPage(new Views.ContratacaoHospedagem())
            {
                BarBackgroundColor = Color.FromArgb("#0E5E6F"),
                BarTextColor = Colors.White
            });

            window.Width = 420;
            window.Height = 760;

            return window;
        }
    }
}
