
namespace Exercicio_3
{
    public class Carro : Veiculo
    {
    public int NumeroDePortas { get; set; }

    public Carro(string marca, string modelo, int numeroDePortas)
        : base(marca, modelo)
    {
        NumeroDePortas = numeroDePortas;
    }

    public override void MostrarInfo()
    {
        Console.WriteLine($"Carro - Marca: {Marca}, Modelo: {Modelo}, Portas: {NumeroDePortas}");
    }
    }
}