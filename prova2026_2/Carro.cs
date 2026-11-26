public class Carro : Veiculo
{
    public int qtdPortas {  get; set; }
    public double tamanhoBagageiro {  get; set; }

    public override double CalcularAluguel(double qtdDias)
    {
        double valorT = 0;
        if( qtdDias > 7)
        {
            valorT = valorDiaria * qtdDias;
            valorT = valorT - (valorT * 0.10);
        }
        return valorT;
    }
}