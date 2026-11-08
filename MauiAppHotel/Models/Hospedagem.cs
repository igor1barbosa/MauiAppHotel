namespace MauiAppHotel.Models
{
    public class Hospedagem
    {
        public Quarto QuartoSelecionado { get; set; } = new Quarto();
        public int QntAdultos { get; set; }
        public int QntCriancas { get; set; }
        public DateTime DataCheckIn { get; set; }
        public DateTime DataCheckOut { get; set; }

        public int Estadia => (DataCheckOut.Date - DataCheckIn.Date).Days;

        public double ValorTotal
        {
            get
            {
                double valorAdultos = QntAdultos * QuartoSelecionado.ValorDiariaAdulto;
                double valorCriancas = QntCriancas * QuartoSelecionado.ValorDiariaCrianca;
                return (valorAdultos + valorCriancas) * Estadia;
            }
        }
    }
}
