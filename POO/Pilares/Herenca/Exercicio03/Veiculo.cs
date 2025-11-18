namespace Exercicio_3
{
    public class Veiculo
    {
    public string Marca { get; set; }
    public string Modelo { get; set; }

    public Veiculo(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
    }

    public virtual void MostrarInfo()
    {
        Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}");
    }
    }
}