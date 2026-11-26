public class Moto : Veiculo
{
    public int cilindradas {  get; set; }
    public string? partidaEletrica {  get; set; }
    public double peso {  get; set; }
    public double capacidadeTanque {  get; set; }

    public override double CalcularAluguel(double qtdDias)
    {
        double valorT = 0;
        if (qtdDias > 5)
        {
            valorT = valorDiaria * qtdDias;
            valorT = valorT - (valorT * 0.15);
        }
        return valorT;
    }
}