namespace MauiAppHotel.Models
{
    public class Hospedagem
    {
        private Quarto _quartoSelecionado = null!;
        private int _qntAdultos = 1;
        private int _qntCriancas;
        private DateTime _dataCheckIn;
        private DateTime _dataCheckOut;

        public Quarto QuartoSelecionado
        {
            get { return _quartoSelecionado; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Selecione uma suíte para continuar.");

                _quartoSelecionado = value;
            }
        }

        public int QntAdultos
        {
            get { return _qntAdultos; }
            set
            {
                if (value < 1)
                    throw new ArgumentException("A reserva precisa ter pelo menos 1 adulto.");

                _qntAdultos = value;
            }
        }

        public int QntCriancas
        {
            get { return _qntCriancas; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("A quantidade de crianças não pode ser negativa.");

                _qntCriancas = value;
            }
        }

        public DateTime DataCheckIn
        {
            get { return _dataCheckIn; }
            set
            {
                if (value.Date < DateTime.Today)
                    throw new ArgumentException("A data de check-in não pode estar no passado.");

                _dataCheckIn = value.Date;
            }
        }

        public DateTime DataCheckOut
        {
            get { return _dataCheckOut; }
            set
            {
                if (value.Date <= _dataCheckIn)
                    throw new ArgumentException("A data de check-out precisa ser depois do check-in.");

                _dataCheckOut = value.Date;
            }
        }

        // Propriedades somente leitura (calculadas)
        public int TotalHospedes => QntAdultos + QntCriancas;

        public int Estadia => (DataCheckOut - DataCheckIn).Days;

        public double ValorTotal
        {
            get
            {
                double valorAdultos = QntAdultos * QuartoSelecionado.ValorDiariaAdulto;
                double valorCriancas = QntCriancas * QuartoSelecionado.ValorDiariaCrianca;
                return (valorAdultos + valorCriancas) * Estadia;
            }
        }

        // Método: confere se a suíte comporta todos os hóspedes
        public void ValidarCapacidade()
        {
            if (TotalHospedes > QuartoSelecionado.Capacidade)
                throw new ArgumentException(
                    $"A {QuartoSelecionado.Descricao} comporta no máximo {QuartoSelecionado.Capacidade} hóspedes. " +
                    $"Você selecionou {TotalHospedes}.");
        }
    }
}
