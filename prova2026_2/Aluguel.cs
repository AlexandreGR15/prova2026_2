public class Aluguel
{
    private Veiculo veiculo { get; set; }
    private DateOnly dataInicio { get; set; }
    private DateOnly dataFim { get; set; }
    public int totalDias {  get; set; }
    private double valorTotal {  get; set; }

    public Aluguel(Veiculo veiculo, DateOnly dataInicio, DateOnly dataFim)
    {
        this.veiculo = veiculo;
        this.dataInicio = dataInicio;
        this.dataFim = dataFim;
        //this.totalDias = totalDias; 
        this.valorTotal = valorTotal;

        if (dataInicio >= dataFim)
            throw new Exception("A data de fim deve ser posterior a data de início, revise as datas informadas!");
        else
            totalDias = (dataFim.DayNumber - dataInicio.DayNumber);
    }

    public double CalcularTotalAluguel()
    {
        valorTotal = 0;
        valorTotal = veiculo.CalcularAluguel(totalDias);
        return valorTotal;
    }
}