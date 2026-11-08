namespace MauiAppHotel.Models
{
    public class Quarto
    {
        // Campos privados (encapsulamento)
        private string _descricao = string.Empty;
        private double _valorDiariaAdulto;
        private double _valorDiariaCrianca;
        private int _capacidade = 1;

        public string Descricao
        {
            get { return _descricao; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("A descrição da suíte não pode ficar vazia.");

                _descricao = value;
            }
        }

        public double ValorDiariaAdulto
        {
            get { return _valorDiariaAdulto; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("O valor da diária de adulto não pode ser negativo.");

                _valorDiariaAdulto = value;
            }
        }

        public double ValorDiariaCrianca
        {
            get { return _valorDiariaCrianca; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("O valor da diária de criança não pode ser negativo.");

                _valorDiariaCrianca = value;
            }
        }

        // Quantidade máxima de hóspedes na suíte
        public int Capacidade
        {
            get { return _capacidade; }
            set
            {
                if (value < 1)
                    throw new ArgumentException("A suíte precisa comportar pelo menos 1 hóspede.");

                _capacidade = value;
            }
        }

        public string Detalhes { get; set; } = string.Empty;

        // Cor usada no cartão da suíte na tela "Nossas Suítes"
        public Color CorDestaque { get; set; } = Colors.Teal;
    }
}
