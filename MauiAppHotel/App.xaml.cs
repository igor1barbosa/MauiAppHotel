using System.Globalization;
using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        // Array de objetos com tamanho dinâmico (List)
        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto()
            {
                Descricao = "Suíte Standard",
                ValorDiariaAdulto = 120,
                ValorDiariaCrianca = 60,
                Capacidade = 2,
                Detalhes = "Cama de casal, ar-condicionado e Wi-Fi.",
                CorDestaque = Color.FromArgb("#5FB3C0")
            },
            new Quarto()
            {
                Descricao = "Suíte Vista Mar",
                ValorDiariaAdulto = 180,
                ValorDiariaCrianca = 90,
                Capacidade = 3,
                Detalhes = "Varanda com vista para o mar e café da manhã.",
                CorDestaque = Color.FromArgb("#0E5E6F")
            },
            new Quarto()
            {
                Descricao = "Suíte Família",
                ValorDiariaAdulto = 150,
                ValorDiariaCrianca = 70,
                Capacidade = 5,
                Detalhes = "Dois quartos, sala integrada e berço sob pedido.",
                CorDestaque = Color.FromArgb("#2E8B57")
            },
            new Quarto()
            {
                Descricao = "Suíte Presidencial",
                ValorDiariaAdulto = 320,
                ValorDiariaCrianca = 160,
                Capacidade = 4,
                Detalhes = "Hidromassagem, cobertura privativa e serviço de quarto 24h.",
                CorDestaque = Color.FromArgb("#C9A227")
            },
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
