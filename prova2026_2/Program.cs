try
{
    Carro car = new Carro();
    Moto mot = new Moto();
    Caminhao cam = new Caminhao();

    car.veiculoID = 1;
    car.descricao = "Carro";
    car.marca = "FIAT";
    car.dataFabricacao = "2006";
    car.valorDiaria = 100;

    car.qtdPortas = 5;
    car.tamanhoBagageiro = 250;

    Aluguel aluguel1 = new Aluguel(car, new DateOnly(2026, 06, 19), new DateOnly(2026, 06, 29));
    Console.WriteLine($"Dados do veículo: {car.marca} - {car.dataFabricacao} - Valor da Diária R${car.valorDiaria}");
    Console.WriteLine($"O valor total do aluguel será R${aluguel1.CalcularTotalAluguel()}");

    mot.veiculoID = 2;
    mot.descricao = "Moto";
    mot.marca = "HONDA";
    mot.dataFabricacao = "2004";
    mot.valorDiaria = 50;

    mot.cilindradas = 110;
    mot.partidaEletrica = "Sim";
    mot.peso = 80;
    mot.capacidadeTanque = 13;

    Aluguel aluguel2 = new Aluguel(mot, new DateOnly(2026, 11, 04), new DateOnly(2026, 11, 14));
    Console.WriteLine($"\nDados do veículo: {mot.marca} - {mot.dataFabricacao} - Valor da Diária R${mot.valorDiaria}");
    Console.WriteLine($"O valor total do aluguel será de R${aluguel2.CalcularTotalAluguel()}");

    cam.veiculoID = 3;
    cam.descricao = "caminhão";
    cam.marca = "SCANIA";
    cam.dataFabricacao = "2025";
    cam.valorDiaria = 350;

    cam.qtdEixo = 9;
    cam.capacidadeCarga = 8000;
    cam.tipoCarroceria = "Baú";
    cam.comprimento = 25;
    cam.altura = 6;

    Aluguel aluguel3 = new Aluguel(cam, new DateOnly(2026, 10, 23), new DateOnly(2026,11,23));
    Console.WriteLine($"\nDados do veículo: {cam.marca} - {cam.dataFabricacao} - Valor da Diária R${cam.valorDiaria}");
    Console.WriteLine($"O valor total do aluguel será de R${aluguel3.CalcularTotalAluguel()}");



}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}