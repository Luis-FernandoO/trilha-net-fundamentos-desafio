namespace DesafioEstacionamento.Model;

public class Estacionamento
{
    public decimal precoInicial { get; set; }
    public decimal precoPorHora { get; set; }
    public List<string> veiculos = new List<string>();

    public Estacionamento(decimal pInicio, decimal pPHora)
    {
        precoInicial = pInicio ;
        precoPorHora = pPHora ;
    }

    public void AdicionarVeiculo()
    {
        Console.WriteLine("Digite o número da placa do veiculo: ");
        var placa = Console.ReadLine();
        veiculos.Add(placa);
        Console.WriteLine("Pressione Qualquer tecla para continuar...");
        Console.Read();
    }

    public void RemoverVeiculo()
    {
        Console.WriteLine("Digite a placa do veiculo para remover: ");
        var placa = Console.ReadLine();
        if (veiculos.Contains(placa))
        {
            veiculos.Remove(placa);
            
            Console.WriteLine("Digite a quantas horas o veiculo ficou estacionado: ");
            int horas = Convert.ToInt32(Console.ReadLine());
            decimal valorEstacionamento = (precoInicial + (precoPorHora * horas));

            Console.WriteLine($"O veiculo {placa} foi removido com sucesso!");
            Console.WriteLine($"Valor do Estacionamento: R${valorEstacionamento},00");
            
            Console.WriteLine("Pressione Qualquer tecla para continuar...");
            Console.Read();

        }
        else
        {
            Console.WriteLine("Veiculo não encontrado no estacionamento!");
        }
    }

    public void ListarVeiculos()
    {
        Console.WriteLine("Veiculos no estacionamento: ");
        foreach (var veiculo in veiculos)
        {
            Console.WriteLine($"Placa: {veiculo}");
        }
        Console.WriteLine("Pressione Qualquer tecla para continuar...");
        Console.Read();
    } 
    
}