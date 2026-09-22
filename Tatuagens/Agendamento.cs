
namespace Tatuagens
{
    class Agendamento
    {
        //PROPRIEDADES
        public string NomeCliente { get; set; } = string.Empty;

        public string ParteCorpo { get; set; } = string.Empty;

        public double Tamanho { get; set; }

        public bool PrimeiraTatuagem { get; set;}

        //MÉTODOS
        
        public double CalcularValorBase()
        {
            const double PRECO = 35.00; // POR CENTIMETRO
            return Math.Round(Tamanho * PRECO, 2);
        }

        public double CalcularValorFinal()
        {
            double valorBase = CalcularValorBase();
            double valorFinal = valorBase;

            if (PrimeiraTatuagem)
            {
                const double DESCONTO = 0.10;
                valorFinal = valorBase - (valorBase * DESCONTO);
            }
            return Math.Round(valorFinal, 2);
           
        }
        public bool validarAgendamento()
        {
            return (Tamanho >= 3.00) && !string.IsNullOrWhiteSpace(NomeCliente);
        }


    }
}
