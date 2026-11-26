public abstract class Veiculo
{
    public int veiculoID {  get; set; }
    public string? descricao { get; set; }
    public string? marca { get; set; }
    public string? dataFabricacao { get; set; }
    public double valorDiaria { get; set; }

    public double ValorDiaria
    {
        get { return valorDiaria; }
        set { if(value < 0)
            {
                throw new Exception("O valor da diária deve ser igual ou maior que zero.");
            } 
            value = valorDiaria;
        }
    }

    public abstract double CalcularAluguel(double qtdDias);
}