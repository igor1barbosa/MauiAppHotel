namespace MauiAppHotel.Models
{
    // Dados exibidos na tela Sobre (ligados via BindingContext)
    public class InfoApp
    {
        public string NomeApp { get; set; } = "Hotel Mar Azul";
        public string Desenvolvedor { get; set; } = "Igor Barbosa";
        public int AnoDesenvolvimento { get; set; } = 2026;
        public string Escola { get; set; } = "ETEC - Centro Paula Souza";
        public string Curso { get; set; } = "Técnico em Desenvolvimento de Sistemas";
        public string Disciplina { get; set; } = "Programação Mobile I";
        public string GitHub { get; set; } = "github.com/igor1barbosa";
        public string Versao { get; set; } = AppInfo.Current.VersionString;
    }
}
