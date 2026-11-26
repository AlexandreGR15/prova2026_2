public class Caminhao : Veiculo
{
    public int qtdEixo {  get; set; }
    public double capacidadeCarga {  get; set; }
    public string? tipoCarroceria {  get; set; }
    public double comprimento {  get; set; }
    public double altura {  get; set; }

    public override double CalcularAluguel(double qtdDias)
    {
        double valorT = 0;
        valorT = valorDiaria * qtdDias;
        if(capacidadeCarga > 10000)
        {
            valorT = valorT + (valorT * 0.20);
        }
        return valorT;
    }
}